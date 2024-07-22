namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Complete()
    {
        using var api = GetAuthorizedApi();
        
        var response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude3Haiku20240307,
            messages: ["Once upon a time"],
            maxTokens: 250,
            metadata: null,
            stopSequences: null,
            system: null,
            temperature: 0,
            toolChoice: null,
            tools: null,
            topK: 0,
            topP: 0,
            stream: false);
        response.Model.Should().Be(CreateMessageRequestModel.Claude3Haiku20240307.ToValueString());
        response.Content.Value2.Should().NotBeNullOrEmpty();
        response.Content.Value2!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
    }
    
    [TestMethod]
    public async Task CompleteHistory()
    {
        using var api = GetAuthorizedApi();
        
        var response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude3Haiku20240307,
            messages: [
                "What's the weather like today?",
                "Sure! Could you please provide me with your location?".AsAssistantMessage(),
                "Dubai, UAE",
            ],
            maxTokens: 300,
            metadata: null,
            stopSequences: null,
            system: null,
            temperature: 0,
            toolChoice: null,
            tools: null,
            topK: 0,
            topP: 0,
            stream: false);
        response.Model.Should().Be(CreateMessageRequestModel.Claude3Haiku20240307.ToValueString());
        response.Content.Value2.Should().NotBeNullOrEmpty();
        response.Content.Value2!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
    }
    
    [TestMethod]
    public async Task Tools()
    {
        using var api = GetAuthorizedApi();
        var service = new WeatherService();
        var tools = service.AsTools();

        var response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude35Sonnet20240620,
            messages: ["What is the current temperature in Dubai, UAE in Celsius?"],
            maxTokens: 300,
            metadata: null,
            stopSequences: null,
            system: "You are a helpful weather assistant.",
            temperature: 0,
            toolChoice: new ToolChoice
            {
                Type = ToolChoiceType.Auto,
                Name = null,
            },
            tools: tools,
            topK: 0,
            topP: 0,
            stream: false);
        response.Model.Should().Be(CreateMessageRequestModel.Claude35Sonnet20240620.ToValueString());
        response.Content.Value2.Should().NotBeNullOrEmpty();
        response.Content.Value2!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.ToolUse);
    }
    
    // [TestMethod]
    // public async Task CreateChatCompletionAsStreamAsync()
    // {
    //     using var api = GetAuthorizedApi();
    //     
    //     var enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
    //         messages: new[]
    //         {
    //             "You are a helpful weather assistant.".AsSystemMessage(),
    //             "What's the weather like today?".AsUserMessage(),
    //         },
    //         model: CreateChatCompletionRequestModel.Gpt35Turbo,
    //         user: "tryAGI.Anthropic.IntegrationTests.Tests.CreateChatCompletion");
    //     
    //     await foreach (var response in enumerable)
    //     {
    //         Console.WriteLine(response.Choices.ElementAt(0).Delta.Content);
    //     }
    // }
}
