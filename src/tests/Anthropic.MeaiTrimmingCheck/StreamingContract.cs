#if PROBE_StreamTools || PROBE_CustomStreamTools || PROBE_StreamCancellation || PROBE_StreamMalformed
using System.Text.Json;
using Anthropic;
using Meai = Microsoft.Extensions.AI;

static class StreamingContract
{
    public static async Task VerifyAsync(AnthropicClient client, ContractHandler handler)
    {
        Meai.IChatClient chat = client;
        var options = new Meai.ChatOptions { ModelId = "fixture", MaxOutputTokens = 32, Tools = [new LookupFunction()] };
        Meai.ChatMessage[] messages = [new(Meai.ChatRole.User, "ping")];
        handler.StreamPayload = Payload;
#if PROBE_StreamCancellation
        using var cancellation = new CancellationTokenSource();
        var partialSeen = false;
        try
        {
            await foreach (var update in chat.GetStreamingResponseAsync(messages, options, cancellation.Token))
            {
                Check(!update.Contents.OfType<Meai.FunctionCallContent>().Any(), "No incomplete function may escape");
                if (update.RawRepresentation is MessageStreamEvent { ContentBlockDelta.Delta.InputJsonDelta: not null })
                {
                    partialSeen = true;
                    cancellation.Cancel();
                }
            }
            throw new InvalidOperationException("Expected cancellation");
        }
        catch (OperationCanceledException) when (cancellation.IsCancellationRequested) { }
        Check(partialSeen && handler.StreamDisposed, "Cancellation after partial input disposes the response stream");
#elif PROBE_StreamMalformed
        handler.StreamPayload = Events(Start,
            """{"type":"content_block_start","index":1,"content_block":{"type":"tool_use","caller":{"type":"direct"},"id":"bad_call","name":"lookup","input":{}}}""",
            """{"type":"content_block_delta","index":1,"delta":{"type":"input_json_delta","partial_json":"{"}}""",
            """{"type":"content_block_stop","index":1}""");
        try
        {
            await foreach (var update in chat.GetStreamingResponseAsync(messages, options))
                Check(!update.Contents.OfType<Meai.FunctionCallContent>().Any(), "Malformed call must not be executable");
            throw new InvalidOperationException("Expected malformed arguments");
        }
        catch (JsonException) { }
        Check(handler.StreamDisposed, "Malformed JSON disposes the response stream");
#else
        var updates = new List<Meai.ChatResponseUpdate>();
        await foreach (var update in chat.GetStreamingResponseAsync(messages, options))
            updates.Add(update);
        Check(handler.StreamDisposed, "Response stream disposed after completion");
        Check(string.Concat(updates.Select(x => x.Text)) == "before after", "Text preserved around tool calls");
        Check(updates.All(x => x.ResponseId == "msg_fixture" && x.MessageId == "msg_fixture" &&
            x.ModelId == "fixture" && x.Role == Meai.ChatRole.Assistant && x.RawRepresentation is MessageStreamEvent), "Response metadata on updates");
        var calls = updates.SelectMany(x => x.Contents).OfType<Meai.FunctionCallContent>().ToArray();
        Check(calls.Select(x => x.CallId).SequenceEqual(["call_second", "call_first", "call_empty", "call_initial"]), "Interleaved calls finish in event order");
        Check(calls.All(x => x.Name == "lookup"), "Function names");
#if PROBE_CustomStreamTools
        Check(calls[0].Arguments?["city"]?.ToString() == "Tokyo-custom" && calls[1].Arguments?["city"]?.ToString() == "Dubai-custom", "Explicit argument context");
        Check(ExplicitContext.RequestWrites == 1 && ExplicitContext.EventReads > 15 && ExplicitContext.DictionaryReads == 4, "Caller contexts used by MEAI streaming");
#else
        Check(calls[0].Arguments?["city"]?.ToString() == "Tokyo" && calls[1].Arguments?["city"]?.ToString() == "Dubai", "Split escaped JSON isolated by block index");
#endif
        Check(((JsonElement)calls[1].Arguments!["details"]!).GetProperty("unit").GetString() == "c" &&
            ((JsonElement)calls[1].Arguments!["days"]!)[1].GetInt32() == 2, "Nested arguments retained");
        Check(calls[2].Arguments?.Count == 0 && calls[3].Arguments?["initial"] is JsonElement initial && initial.GetBoolean(), "Empty and initial inputs without deltas");
        var stop = updates.Single(x => x.FinishReason is not null);
        Check(stop.FinishReason == Meai.ChatFinishReason.ToolCalls && stop.AdditionalProperties?["StopSequence"]?.ToString() == "fixture_stop", "Tool finish metadata");
        var response = updates.ToChatResponse();
        Check(response.ResponseId == "msg_fixture" && response.ModelId == "fixture" &&
            response.FinishReason == Meai.ChatFinishReason.ToolCalls, "MEAI response aggregation");
        Check(response.Usage?.InputTokenCount == 4 && response.Usage.OutputTokenCount == 5 &&
            response.Usage.TotalTokenCount == 9 && response.Usage.AdditionalCounts?["CacheCreationInputTokens"] == 6 &&
            response.Usage.AdditionalCounts?["CacheReadInputTokens"] == 8, "Cumulative usage counted once");
        foreach (var (reason, expected) in new[]
        {
            ("end_turn", Meai.ChatFinishReason.Stop),
            ("stop_sequence", Meai.ChatFinishReason.Stop),
            ("max_tokens", Meai.ChatFinishReason.Length),
        })
        {
            handler.StreamPayload = MinimalPayload(reason);
            var results = new List<Meai.ChatResponseUpdate>();
            await foreach (var update in chat.GetStreamingResponseAsync(messages, options))
                results.Add(update);
            Check(results.Single(x => x.FinishReason is not null).FinishReason == expected, reason);
        }
#endif
    }

    private static void Check(bool condition, string contract)
    {
        if (!condition) throw new InvalidOperationException(contract);
    }

    private static string Events(params string[] events) => string.Concat(events.Select(json =>
    {
        using var document = JsonDocument.Parse(json);
        return $"event: {document.RootElement.GetProperty("type").GetString()}\ndata: {json}\n\n";
    }));

    private static string MinimalPayload(string reason) => Events(
        Start,
        """{"type":"message_delta","delta":{"stop_reason":"REASON","stop_sequence":null},"usage":{"output_tokens":0}}""".Replace("REASON", reason, StringComparison.Ordinal),
        """{"type":"message_stop"}""");

    private const string Start = """{"type":"message_start","message":{"id":"msg_fixture","type":"message","role":"assistant","content":[],"model":"fixture","stop_reason":null,"stop_sequence":null,"usage":{"input_tokens":3,"output_tokens":1,"cache_creation_input_tokens":5,"cache_read_input_tokens":7}}}""";

    private static string Payload => Events(
        Start,
        """{"type":"content_block_start","index":0,"content_block":{"type":"text","text":""}}""",
        """{"type":"content_block_delta","index":0,"delta":{"type":"text_delta","text":"before "}}""",
        """{"type":"content_block_stop","index":0}""",
        """{"type":"content_block_start","index":1,"content_block":{"type":"tool_use","caller":{"type":"direct"},"id":"call_first","name":"lookup","input":{}}}""",
        """{"type":"content_block_start","index":2,"content_block":{"type":"tool_use","caller":{"type":"direct"},"id":"call_second","name":"lookup","input":{}}}""",
        """{"type":"content_block_delta","index":1,"delta":{"type":"input_json_delta","partial_json":"{\"city\":\"D"}}""",
        """{"type":"content_block_delta","index":2,"delta":{"type":"input_json_delta","partial_json":"{\"city\":\"Tokyo\"}"}}""",
        """{"type":"content_block_delta","index":1,"delta":{"type":"input_json_delta","partial_json":"ub\\u0061i\",\"details\":{\"unit\":\"c\"},\"days\":[1,2]}"}}""",
        """{"type":"content_block_stop","index":2}""",
        """{"type":"content_block_stop","index":1}""",
        """{"type":"content_block_start","index":3,"content_block":{"type":"tool_use","caller":{"type":"direct"},"id":"call_empty","name":"lookup","input":{}}}""",
        """{"type":"content_block_stop","index":3}""",
        """{"type":"content_block_start","index":4,"content_block":{"type":"tool_use","caller":{"type":"direct"},"id":"call_initial","name":"lookup","input":{"initial":true}}}""",
        """{"type":"content_block_stop","index":4}""",
        """{"type":"content_block_start","index":5,"content_block":{"type":"text","text":""}}""",
        """{"type":"content_block_delta","index":5,"delta":{"type":"text_delta","text":"after"}}""",
        """{"type":"content_block_stop","index":5}""",
        """{"type":"message_delta","delta":{"stop_reason":null,"stop_sequence":null},"usage":{"output_tokens":3}}""",
        """{"type":"message_delta","delta":{"stop_reason":"tool_use","stop_sequence":"fixture_stop"},"usage":{"input_tokens":4,"output_tokens":5,"cache_creation_input_tokens":6,"cache_read_input_tokens":8}}""",
        """{"type":"message_delta","delta":{"stop_reason":null,"stop_sequence":null},"usage":{"output_tokens":5}}""",
        """{"type":"message_stop"}""");
}

// Fragment every SSE field and JSON string across reads; no network or provider credentials.
sealed class FragmentedStream(byte[] bytes, Action onDispose) : MemoryStream(bytes)
{
    public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        return base.ReadAsync(buffer[..Math.Min(buffer.Length, 7)], cancellationToken);
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing) onDispose();
        base.Dispose(disposing);
    }
}
#endif
