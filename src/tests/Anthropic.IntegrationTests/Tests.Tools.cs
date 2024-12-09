namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Tools()
    {
        using var client = GetAuthenticatedClient();
        var service = new WeatherService();
        var tools = service.AsTools().AsAnthropicTools();

        List<InputMessage> messages = ["What is the current temperature in Dubai, UAE in Celsius?"];

        var response = await client.Messages.MessagesPostAsync(
            model: ModelEnum.Claude35Sonnet20240620,
            messages: messages,
            maxTokens: 300,
            metadata: null,
            stopSequences: null,
            system: "You are a helpful weather assistant.",
            temperature: 0,
            toolChoice: new ToolChoiceAuto(),
            tools: tools,
            topK: 0,
            topP: 0,
            stream: false);
        response.Model.Object.Should().Be(ModelEnum.Claude35Sonnet20240620);
        response.Content.Should().NotBeNullOrEmpty();
        response.Content.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(MessageStopReason.ToolUse);

        messages.Add(response.AsInputMessage());
        
        foreach (var toolUse in response.Content
                     .Where(x => x.IsToolUse)
                     .Select(x => x.ToolUse))
        {
            var json = await service.CallAsync(
                functionName: toolUse!.Name,
                argumentsAsJson: toolUse.Input.AsJson());
            messages.Add(json.AsToolCall(toolUse));
        }

        response = await client.Messages.MessagesPostAsync(
            model: ModelEnum.Claude35Sonnet20240620,
            messages: messages,
            maxTokens: 300,
            metadata: null,
            stopSequences: null,
            system: "You are a helpful weather assistant.",
            temperature: 0,
            toolChoice: new ToolChoiceAuto(),
            tools: tools,
            topK: 0,
            topP: 0,
            stream: false);
        response.Model.Object.Should().Be(ModelEnum.Claude35Sonnet20240620);
        response.Content.Should().NotBeNullOrEmpty();
        response.Content!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(MessageStopReason.EndTurn);
        response.AsSimpleText().Should().NotBeNullOrEmpty();
        
        Console.WriteLine(response.AsSimpleText());
    }
}
