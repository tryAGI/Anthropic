/*
order: 40
title: Complete History
slug: complete-history
*/

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CompleteHistory()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.MessagesPostAsync(
            model: DefaultModel,
            messages: [
                "What's the weather like today?",
                "Sure! Could you please provide me with your location?".AsAssistantMessage(),
                "Dubai, UAE",
            ],
            maxTokens: 300,
            temperature: 0);
        response.Model.ToString().Should().Contain("claude-sonnet");
        response.Content.Should().NotBeNullOrEmpty();
        response.Content.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
        response.AsSimpleText().Should().NotBeNullOrEmpty();
        
        Console.WriteLine(response.AsSimpleText());
    }
}
