using System.Net.Http;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    /// <summary>
    /// `auto` is the API's own default, so it is easy to leave unsent - but then there is nowhere to
    /// put the parallel-tool-use opt-out, and the model keeps making parallel calls.
    /// </summary>
    [TestMethod]
    public async Task AllowMultipleToolCallsFalseSendsDisableParallelToolUse()
    {
        var body = await CaptureRequestBodyAsync(new ChatOptions
        {
            ModelId = "claude-haiku-5-5",
            MaxOutputTokens = 16,
            AllowMultipleToolCalls = false,
            Tools = [AIFunctionFactory.Create((string city) => city, "get_weather", "Get the weather.")],
        });

        using var document = JsonDocument.Parse(body);
        var toolChoice = document.RootElement.GetProperty("tool_choice");
        toolChoice.GetProperty("type").GetString().Should().Be("auto");
        toolChoice.GetProperty("disable_parallel_tool_use").GetBoolean().Should().BeTrue();
    }

    [TestMethod]
    public async Task HostedWebSearchMapsToTheCurrentToolVersion()
    {
        var body = await CaptureRequestBodyAsync(new ChatOptions
        {
            ModelId = "claude-haiku-5-5",
            MaxOutputTokens = 16,
            Tools = [new HostedWebSearchTool()],
        });

        using var document = JsonDocument.Parse(body);
        document.RootElement.GetProperty("tools")[0].GetProperty("type").GetString()
            .Should().Be("web_search_20260209");
    }

    [TestMethod]
    public async Task JsonResponseFormatMapsToOutputConfigFormat()
    {
        var body = await CaptureRequestBodyAsync(new ChatOptions
        {
            ModelId = "claude-haiku-5-5",
            MaxOutputTokens = 16,
            ResponseFormat = ChatResponseFormat.ForJsonSchema(JsonSerializer.Deserialize<JsonElement>(
                """
                {"type":"object","properties":{"capital":{"type":"string"}},"required":["capital"]}
                """)),
        });

        using var document = JsonDocument.Parse(body);
        var format = document.RootElement.GetProperty("output_config").GetProperty("format");
        format.GetProperty("type").GetString().Should().Be("json_schema");
        format.GetProperty("schema").GetProperty("properties").TryGetProperty("capital", out _)
            .Should().BeTrue();
    }

    private static async Task<string> CaptureRequestBodyAsync(ChatOptions options)
    {
        var handler = new CapturingHandler(StubMessageJson);
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://api.anthropic.com"),
        };
        using var client = new AnthropicClient(httpClient, authorizations: null, options: null);

        _ = await ((IChatClient)client).GetResponseAsync("hello", options);

        return handler.RequestBody ?? throw new InvalidOperationException("no request body was captured");
    }
}
