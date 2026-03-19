/*
order: 10
title: Chat Client Five Random Lines
slug: chat-client-five-random-lines
*/

using System.Text.Json;
using System.Text.Json.Schema;
using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomLines()
    {
        using var client = GetAuthenticatedChatClient();

        var response = await client.GetResponseAsync(
            messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
            new ChatOptions
            {
                ModelId = DefaultModel,
                ResponseFormat = ChatResponseFormatForType<StringArraySchema>(),
                Tools = new List<AITool>(),
            });

        Console.WriteLine(response.ToString());
    }

    private sealed class StringArraySchema
    {
        public string[] Value { get; set; } = [];
    }

    private static ChatResponseFormatJson ChatResponseFormatForType<T>(
        string? schemaName = null,
        string? schemaDescription = null)
    {
        return ChatResponseFormat.ForJsonSchema(
            JsonSerializerOptions.Default.GetJsonSchemaAsNode(typeof(T), new JsonSchemaExporterOptions
            {
                TreatNullObliviousAsNonNullable = true,
            }).Deserialize<JsonElement>(), schemaName, schemaDescription);
    }
}
