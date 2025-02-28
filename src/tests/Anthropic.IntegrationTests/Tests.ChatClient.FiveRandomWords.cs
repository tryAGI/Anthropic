using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords()
    {
        using var client = GetAuthenticatedChatClient();
        
        var response = await client.GetResponseAsync(
            chatMessages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
            new ChatOptions
            {
                ModelId = ModelVariant2.Claude37SonnetLatest.ToValueString(),
            });
        
        Console.WriteLine(response.ToString());
    }
    
    [TestMethod]
    public async Task ChatClient_FiveRandomWords_Streaming()
    {
        using var client = GetAuthenticatedChatClient();
        
        var enumerable = client.GetStreamingResponseAsync(
            chatMessages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
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
}
