namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Tools()
    {
        using var api = GetAuthorizedApi();
        var service = new WeatherService();
        var tools = service.AsTools().AsAnthropicTools();

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
        response.AsSimpleText().Should().NotBeNullOrEmpty();
        
        Console.WriteLine(response.AsSimpleText());
    }
}
