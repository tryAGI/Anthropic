/*
order: 20
title: Chat Client Five Random Words Streaming
slug: chat-client-five-random-words-streaming
*/

using System.Text.Json;
using System.Text.Json.Schema;
using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords_Streaming()
    {
        using var client = GetAuthenticatedChatClient();

        var enumerable = client.GetStreamingResponseAsync(
            messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
            new ChatOptions
            {
                ModelId = DefaultModel,
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
