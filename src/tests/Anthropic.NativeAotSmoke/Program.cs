using System.Text.Json;
using Anthropic;

if (JsonSerializer.IsReflectionEnabledByDefault)
{
    throw new InvalidOperationException("System.Text.Json reflection serialization is still enabled.");
}

var request = new CreateMessageParams
{
    Model = "claude-sonnet-4-5",
    Messages =
    [
        InputMessage.ToInputMessage("Hello from NativeAOT."),
    ],
    MaxTokens = 64,
};

var requestJson = request.ToJson();
Check(requestJson.Contains("\"messages\"", StringComparison.Ordinal), "Request JSON did not contain messages.");

var roundTrippedRequest = CreateMessageParams.FromJson(requestJson)
    ?? throw new InvalidOperationException("CreateMessageParams deserialized to null.");
Check(roundTrippedRequest.Messages.Count == 1, "Request message count did not round-trip.");
Check(roundTrippedRequest.Messages[0].AsSimpleText() == "Hello from NativeAOT.", "Request message text did not round-trip.");

const string responseJson = """
    {
      "id": "msg_native_aot_smoke",
      "type": "message",
      "role": "assistant",
      "content": [
        {
          "type": "text",
          "text": "ok"
        }
      ],
      "model": "claude-sonnet-4-5",
      "stop_reason": "end_turn",
      "stop_sequence": null,
      "usage": {
        "input_tokens": 3,
        "output_tokens": 1
      }
    }
    """;

var message = Message.FromJson(responseJson)
    ?? throw new InvalidOperationException("Message deserialized to null.");
Check(message.AsSimpleText() == "ok", "Response text did not deserialize.");

var messageJson = message.ToJson();
Check(messageJson.Contains("\"usage\"", StringComparison.Ordinal), "Response JSON did not contain usage.");

Console.WriteLine("Anthropic NativeAOT serialization smoke passed.");

static void Check(bool condition, string message)
{
    if (!condition)
    {
        throw new InvalidOperationException(message);
    }
}
