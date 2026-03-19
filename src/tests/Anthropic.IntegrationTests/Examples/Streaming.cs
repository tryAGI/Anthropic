/*
order: 60
title: Streaming
slug: streaming
*/

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Streaming()
    {
        using var client = GetAuthenticatedClient();
        
        var enumerable = client.CreateMessageAsStreamAsync(new CreateMessageParams
        {
            Model = DefaultModel,
            Messages = ["Once upon a time"],
            MaxTokens = 250,
        });
        
        var deltas = new List<string>();
        await foreach (var response in enumerable)
        {
            Console.Write(response.ContentBlockDelta?.Delta.TextDelta?.Text);
            
            deltas.Add(response.ContentBlockDelta?.Delta.TextDelta?.Text ?? string.Empty);
        }
        
        deltas.Should().NotBeEmpty().And.HaveCountGreaterThan(5);
    }
}
