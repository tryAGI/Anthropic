/*
order: 30
title: Chat Client Five Random Words
slug: chat-client-five-random-words
*/

using System.Text.Json;
using System.Text.Json.Schema;
using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords()
    {
        using var client = GetAuthenticatedChatClient();

        var response = await client.GetResponseAsync(
            messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
            new ChatOptions
            {
                ModelId = DefaultModel,
            });

        Console.WriteLine(response.ToString());
    }
}
