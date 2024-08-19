namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Streaming()
    {
        using var api = GetAuthorizedApi();
        
        var enumerable = api.CreateMessageAsStreamAsync(new CreateMessageRequest
        {
            Model = CreateMessageRequestModel.Claude35Sonnet20240620,
            Messages = ["Once upon a time"],
            MaxTokens = 250,
        });
        
        await foreach (var response in enumerable)
        {
            Console.WriteLine(response.ContentBlockDelta?.Delta.Text?.Text);
        }
    }
}
