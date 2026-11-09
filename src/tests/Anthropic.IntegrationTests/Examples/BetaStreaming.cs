/*
order: 65
title: Beta streaming
slug: beta-streaming
*/

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    //// Beta-only capabilities — fast mode, task budgets, compaction, context editing, cache
    //// diagnostics — live on the beta messages endpoint. `CreateBetaMessageAsStreamAsync` streams
    //// it, and the beta flags you pass become the `anthropic-beta` header.
    [TestMethod]
    public async Task BetaStreaming()
    {
        using var client = GetAuthenticatedClient();

        var enumerable = client.CreateBetaMessageAsStreamAsync(
            new BetaCreateMessageParams
            {
                Model = "claude-sonnet-5-5",
                Messages = ["Once upon a time"],
                MaxTokens = 250,
                //// Effort is the first cost lever: it trades thoroughness against token spend
                //// within one model.
                OutputConfig = new BetaOutputConfig
                {
                    Effort = BetaEffortLevel.Low,
                },
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
