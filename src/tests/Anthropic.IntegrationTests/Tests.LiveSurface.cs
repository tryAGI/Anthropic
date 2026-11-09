using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

/// <summary>
/// Probes that only a real API can answer: whether the request shapes this SDK generates are the
/// ones the service accepts, and whether real responses deserialize.
/// </summary>
/// <remarks>
/// Every probe here earned its place by catching a bug that offline tests could not see - a spec
/// that required a field the API omits, a header serialized as a CLR type name, a path carrying a
/// marker that only exists to key the spec. They run on <c>claude-haiku-5-5</c> with small token
/// limits, so a full pass costs a few cents; the three web-search probes are the expensive ones, at
/// roughly a cent each.
/// </remarks>
public partial class Tests
{
    private const string CheapModel = "claude-haiku-5-5";

    /// <summary>
    /// The beta endpoint is keyed in the spec as `/v1/messages?beta=true`, and that marker used to
    /// be sent to the API as a query parameter. The beta flags used to be sent as a CLR type name.
    /// </summary>
    [TestMethod]
    public async Task Live_BetaEndpointAcceptsTheBetaHeaderAndPath()
    {
        using var client = GetAuthenticatedClient();

        var count = await client.BetaMessagesCountTokensPostAsync(
            new BetaCountMessageTokensParams
            {
                Model = CheapModel,
                Messages = ["How many tokens is this?"],
            },
            anthropicBeta: [new AnthropicBeta(AnthropicBetaEnum.TokenCounting20241101)]);

        count.InputTokens.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public async Task Live_BetaMessagesStream()
    {
        using var client = GetAuthenticatedClient();

        var deltas = new List<string>();
        await foreach (var @event in client.CreateBetaMessageAsStreamAsync(new BetaCreateMessageParams
        {
            Model = CheapModel,
            MaxTokens = 48,
            Messages = ["Count from one to five."],
            OutputConfig = new BetaOutputConfig { Effort = BetaEffortLevel.Low },
        }))
        {
            if (@event.ContentBlockDelta?.Delta.TextDelta?.Text is { } text)
            {
                deltas.Add(text);
            }
        }

        deltas.Should().NotBeEmpty();
    }

    /// <summary>
    /// Context editing is one of the capabilities that only exists behind a beta flag, so it fails
    /// outright if the header does not arrive intact.
    /// </summary>
    [TestMethod]
    public async Task Live_BetaStreamWithContextManagement()
    {
        using var client = GetAuthenticatedClient();

        var deltas = new List<string>();
        await foreach (var @event in client.CreateBetaMessageAsStreamAsync(
            new BetaCreateMessageParams
            {
                Model = CheapModel,
                MaxTokens = 48,
                Messages = ["Say hello."],
                ContextManagement = new BetaContextManagementConfig
                {
                    Edits = [new BetaClearToolUses20250919()],
                },
            },
            anthropicBeta: [new AnthropicBeta(AnthropicBetaEnum.ContextManagement20250627)]))
        {
            if (@event.ContentBlockDelta?.Delta.TextDelta?.Text is { } text)
            {
                deltas.Add(text);
            }
        }

        deltas.Should().NotBeEmpty();
    }

    /// <summary>
    /// The spec marks `caller` as required on 52 response block schemas and the API does not send it
    /// on `server_tool_use`, so this used to throw while deserializing a successful HTTP 200.
    /// </summary>
    [TestMethod]
    public async Task Live_WebSearchServerToolResponseDeserializes()
    {
        using var client = GetAuthenticatedClient();

        var message = await client.MessagesPostAsync(new CreateMessageParams
        {
            Model = CheapModel,
            MaxTokens = 1024,
            Messages = ["Search the web: what is the latest stable .NET version? One sentence."],
            Tools = [new WebSearchTool20260209 { MaxUses = 1 }],
        });

        message.Content.Should().Contain(x => x.IsWebSearchToolResult);
    }

    /// <summary>
    /// The beta block schemas declare `caller` as optional rather than required, so the beta path
    /// was never affected - this keeps that true.
    /// </summary>
    [TestMethod]
    public async Task Live_BetaWebSearchServerToolResponseDeserializes()
    {
        using var client = GetAuthenticatedClient();

        var message = await client.BetaMessagesPostAsync(new BetaCreateMessageParams
        {
            Model = CheapModel,
            MaxTokens = 1024,
            Messages = ["Search the web: what is the latest stable .NET version? One sentence."],
            Tools = [new BetaWebSearchTool20260209 { MaxUses = 1 }],
        });

        message.Content.Should().Contain(x => x.IsWebSearchToolResult);
    }

    [TestMethod]
    public async Task Live_CustomToolRoundTrip()
    {
        using var client = GetAuthenticatedClient();

        var request = new CreateMessageParams
        {
            Model = CheapModel,
            MaxTokens = 256,
            Messages = ["What is the weather in Paris? Use the tool."],
        };
        request.Tools =
        [
            new Tool5
            {
                Name = "get_weather",
                Description = "Get the weather for a city.",
                InputSchema = JsonSerializer.Deserialize<JsonElement>(
                    """
                    {"type":"object","properties":{"city":{"type":"string"}},"required":["city"]}
                    """),
            },
        ];

        var first = await client.MessagesPostAsync(request);
        var toolUse = first.Content
            .Where(x => x.IsToolUse)
            .Select(x => x.ToolUse)
            .FirstOrDefault();
        toolUse.Should().NotBeNull();

        var second = await client.MessagesPostAsync(new CreateMessageParams
        {
            Model = CheapModel,
            MaxTokens = 256,
            Messages =
            [
                "What is the weather in Paris? Use the tool.",
                InputMessageUnion.FromAssistant(new AssistantInputMessage
                {
                    Content = new(null,
                    [
                        new InputContentBlock(new RequestToolUseBlock
                        {
                            Id = toolUse!.Id,
                            Name = toolUse.Name,
                            Input = toolUse.Input ?? new Dictionary<string, object?>(),
                        }),
                    ]),
                }),
                InputMessageUnion.FromUser(new UserInputMessage
                {
                    Content = new(null,
                    [
                        new InputContentBlock(new RequestToolResultBlock
                        {
                            ToolUseId = toolUse.Id,
                            Content = new("12 degrees and raining"),
                        }),
                    ]),
                }),
            ],
            Tools = request.Tools,
        });

        second.AsSimpleText().Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Live_FilesRoundTrip()
    {
        using var client = GetAuthenticatedClient();

        var uploaded = await client.UploadFileV1FilesPostAsync(new UploadFileV1FilesPostRequest
        {
            File = System.Text.Encoding.UTF8.GetBytes("hello from the tryAGI live surface tests\n"),
            Filename = "probe.txt",
        });
        uploaded.Id.Should().NotBeEmpty();

        try
        {
            var metadata = await client.GetFileMetadataV1FilesFileIdGetAsync(uploaded.Id);
            metadata.Id.Should().Be(uploaded.Id);
        }
        finally
        {
            _ = await client.DeleteFileV1FilesFileIdDeleteAsync(uploaded.Id);
        }
    }

    [TestMethod]
    public async Task Live_MessageBatchCreateAndCancel()
    {
        using var client = GetAuthenticatedClient();

        var batch = await client.MessageBatchesPostAsync(new CreateMessageBatchParams
        {
            Requests =
            [
                new MessageBatchIndividualRequestParams
                {
                    CustomId = "probe-1",
                    Params = new CreateMessageParams
                    {
                        Model = CheapModel,
                        MaxTokens = 16,
                        Messages = ["Reply with the single word: ping"],
                    },
                },
            ],
        });
        batch.Id.Should().NotBeEmpty();

        var cancelled = await client.MessageBatchesCancelAsync(batch.Id);
        cancelled.Id.Should().Be(batch.Id);
    }

    /// <summary>
    /// Managed Agents and the Admin API are reached through the same beta header path; an empty list
    /// is a pass, a transport or deserialization error is not.
    /// </summary>
    [TestMethod]
    public async Task Live_ManagedAgentsAndAdminSurfacesAreReachable()
    {
        using var client = GetAuthenticatedClient();

        var agents = await client.BetaListAgentsAsync(
            anthropicBeta: [new AnthropicBeta(AnthropicBetaEnum.ManagedAgents20260401)],
            limit: 5);
        agents.Data.Should().NotBeNull();

        var organization = await client.GetCurrentOrganizationV1OrganizationsMeGetAsync();
        organization.Id.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Live_ModelsAutoPaging()
    {
        using var client = GetAuthenticatedClient();

        var seen = 0;
        await foreach (var _ in client.ModelsListAutoPagingAsync(limit: 2))
        {
            if (++seen >= 5)
            {
                break;
            }
        }

        seen.Should().BeGreaterThan(2);
    }

    [TestMethod]
    public async Task Live_MeaiHostedWebSearch()
    {
        IChatClient client = GetAuthenticatedChatClient();

        var response = await client.GetResponseAsync(
            "Search the web: what is the latest stable .NET version? One sentence.",
            new ChatOptions
            {
                ModelId = CheapModel,
                MaxOutputTokens = 1024,
                Tools = [new HostedWebSearchTool()],
            });

        response.Text.Should().NotBeEmpty();
    }
}
