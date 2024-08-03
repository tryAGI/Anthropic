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

        List<Message> messages = ["What is the current temperature in Dubai, UAE in Celsius?"];

        var response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude35Sonnet20240620,
            messages: messages,
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

        messages.Add(response.AsRequestMessage());
        
        foreach (var toolUse in response.Content.Value2!
                     .Where(x => x.IsToolUse)
                     .Select(x => x.ToolUse))
        {
            var json = await service.CallAsync(
                functionName: toolUse!.Name,
                argumentsAsJson: toolUse.Input.AsJson());
            messages.Add(json.AsToolCall(toolUse));
        }

        response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude35Sonnet20240620,
            messages: messages,
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
        response.StopReason.Should().Be(StopReason.EndTurn);
    }
    
    [TestMethod]
    public async Task Streaming()
    {
        using var api = GetAuthorizedApi();
        
        var enumerable = api.CreateMessageAsStreamAsync(new CreateMessageRequest
        {
            Model = CreateMessageRequestModel.Claude3Haiku20240307,
            Messages = ["Once upon a time"],
            MaxTokens = 250,
        });
        
        await foreach (var response in enumerable)
        {
            Console.WriteLine(response.ContentBlockDelta?.Delta.Value1?.Text);
        }
    }
}
