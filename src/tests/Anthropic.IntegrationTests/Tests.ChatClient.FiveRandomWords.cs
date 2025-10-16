using System.Text.Json;
using System.Text.Json.Schema;
using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords()
    {
        using var client = GetAuthenticatedChatClient();
        
        var response = await client.GetResponseAsync(
            messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
            new ChatOptions
            {
                ModelId = ModelVariant9.ClaudeSonnet40.ToValueString(),
            });
        
        Console.WriteLine(response.ToString());
    }
    
    [TestMethod]
    public async Task ChatClient_FiveRandomLines()
    {
        using var client = GetAuthenticatedChatClient();
        
        var response = await client.GetResponseAsync(
            messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
            new ChatOptions
            {
                ModelId = ModelVariant9.ClaudeSonnet40.ToValueString(),
                ResponseFormat = ChatResponseFormatForType<StringArraySchema>(),
                Tools = new List<AITool>(),
            });
        
        Console.WriteLine(response.ToString());
    }
    
    [TestMethod]
    public async Task ChatClient_FiveRandomWords_Streaming()
    {
        using var client = GetAuthenticatedChatClient();
        
        var enumerable = client.GetStreamingResponseAsync(
            messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
            new ChatOptions
            {
                ModelId = ModelVariant2.Claude37SonnetLatest.ToValueString(),
            });
        
        var deltas = new List<string>();
        await foreach (var response in enumerable)
        {
            Console.Write(response.ToString());
            
            deltas.Add(response.ToString());
        }
        
        deltas.Should().NotBeEmpty().And.HaveCountGreaterThan(5);
    }
    
    public static ChatResponseFormatJson ChatResponseFormatForType<T>(
        string? schemaName = null,
        string? schemaDescription = null)
    {
        return ChatResponseFormat.ForJsonSchema(
            JsonSerializerOptions.Default.GetJsonSchemaAsNode(typeof(T), new JsonSchemaExporterOptions
            {
                // Marks root-level types as non-nullable
                TreatNullObliviousAsNonNullable = true,
            }).Deserialize<JsonElement>(), schemaName, schemaDescription);
    }
}


internal sealed class StringArraySchema
{
    public string[] Value { get; set; } = [];
}