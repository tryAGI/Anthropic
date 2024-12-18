namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Streaming()
    {
        using var client = GetAuthenticatedClient();
        
        var enumerable = client.CreateMessageAsStreamAsync(new CreateMessageParams
        {
            Model = ModelEnum.Claude35Sonnet20240620,
            Messages = ["Once upon a time"],
            MaxTokens = 250,
        }, anthropicVersion: "2023-06-01");
        
        var deltas = new List<string>();
        await foreach (var response in enumerable)
        {
            Console.Write(response.ContentBlockDelta?.Delta.Value1?.Text);
            
            deltas.Add(response.ContentBlockDelta?.Delta.Value1?.Text ?? string.Empty);
        }
        
        deltas.Should().NotBeEmpty().And.HaveCountGreaterThan(5);
    }
}
