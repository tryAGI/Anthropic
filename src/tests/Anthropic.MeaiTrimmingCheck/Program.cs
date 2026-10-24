using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Anthropic;
using Meai = Microsoft.Extensions.AI;

if (JsonSerializer.IsReflectionEnabledByDefault)
    throw new InvalidOperationException("Reflection serialization must be disabled.");

using var handler = new ContractHandler();
using var http = new HttpClient(handler) { BaseAddress = new Uri(AnthropicClient.DefaultBaseUrl) };
http.DefaultRequestHeaders.Add("x-consumer-header", "preserved");
using var client = new AnthropicClient(httpClient: http, authorizations:
[
    new EndPointAuthorization { Type = "ApiKey", Location = "Header", Name = "x-api-key", Value = "offline" },
]);
#if PROBE_CustomStream || PROBE_CustomTools
client.JsonSerializerContext = new ExplicitContext(new JsonSerializerOptions());
#endif

#if PROBE_Chat
Meai.IChatClient chat = client;
var response = await chat.GetResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "ping")],
    new Meai.ChatOptions { ModelId = "fixture", MaxOutputTokens = 32 });
Require(response.Text == "pong" && response.ResponseId == "msg_fixture", "MEAI response");
Require(response.Usage?.InputTokenCount == 3 && response.Usage.OutputTokenCount == 2, "MEAI usage");
#elif PROBE_TypedChat
var response = await client.MessagesPostAsync(CreateRequest());
Require(response.AsSimpleText() == "pong" && response.Id == "msg_fixture", "Typed response");
#elif PROBE_Tools || PROBE_CustomTools
Meai.IChatClient chat = client;
var response = await chat.GetResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "ping")],
    new Meai.ChatOptions { ModelId = "fixture", MaxOutputTokens = 32, Tools = [new LookupFunction()] });
var call = response.Messages.Single().Contents.OfType<Meai.FunctionCallContent>().Single();
Require(call.Name == "lookup" && call.CallId == "call_fixture", "Tool identity");
#if PROBE_CustomTools
Require(call.Arguments?["city"]?.ToString() == "Dubai-custom", "Explicit tool argument converter");
Require(ExplicitContext.RequestWrites > 0 && ExplicitContext.MessageReads > 0 && ExplicitContext.DictionaryReads > 0, "Explicit tool context");
#else
Require(call.Arguments?["city"]?.ToString() == "Dubai", "Tool arguments");
#endif
using (var body = JsonDocument.Parse(handler.LastBody!))
{
    var schema = body.RootElement.GetProperty("tools")[0].GetProperty("input_schema");
    Require(schema.GetProperty("properties").GetProperty("city").GetProperty("type").GetString() == "string", "Tool schema");
    Require(!schema.GetProperty("additionalProperties").GetBoolean() && schema.GetProperty("minProperties").GetInt32() == 1, "Tool schema keywords");
}
#elif PROBE_Stream
Meai.IChatClient chat = client;
var text = new StringBuilder();
await foreach (var update in chat.GetStreamingResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "ping")],
    new Meai.ChatOptions { ModelId = "fixture", MaxOutputTokens = 32 }))
    text.Append(update.Text);
Require(text.ToString() == "pong", "MEAI stream");
#elif PROBE_TypedStream || PROBE_CustomStream
var text = new StringBuilder();
var count = 0;
await foreach (var item in client.CreateMessageAsStreamAsync(CreateRequest()))
{
    count++;
    if (item.IsContentBlockDelta && item.ContentBlockDelta!.Delta.IsTextDelta)
        text.Append(item.ContentBlockDelta.Delta.TextDelta!.Text);
}
Require(count == 2 && text.ToString() == "pong", "Typed stream events");
#if PROBE_CustomStream
Require(ExplicitContext.RequestWrites > 0 && ExplicitContext.EventReads == 2, "Explicit streaming context");
#endif
#elif PROBE_ErrorString || PROBE_ErrorStream
#if PROBE_ErrorString
client.ReadResponseAsString = true;
#else
client.ReadResponseAsString = false;
#endif
try
{
    await foreach (var item in client.CreateMessageAsStreamAsync(CreateRequest()))
        throw new InvalidOperationException("Unexpected success event");
    throw new InvalidOperationException("Expected typed API error");
}
catch (ApiException<ErrorResponse> error)
{
    Require(error.StatusCode == HttpStatusCode.BadRequest, "Error status");
    Require(error.ResponseObject?.RequestId == "req_fixture", "Error payload");
    Require(error.ResponseHeaders?.Any(header => string.Equals(header.Key, "x-request-id", StringComparison.OrdinalIgnoreCase) && header.Value.Single() == "req_fixture") is true, "Error headers");
}
#else
#error Unknown probe scenario
#endif

Require(handler.Calls == 1, "Exactly one offline request");
Console.WriteLine("Anthropic MEAI offline contract passed.");
return;

#if PROBE_TypedChat || PROBE_TypedStream || PROBE_CustomStream || PROBE_ErrorString || PROBE_ErrorStream
static CreateMessageParams CreateRequest() => new()
{
    Model = "fixture",
    MaxTokens = 32,
    Messages = [InputMessage.ToInputMessage("ping")],
};
#endif

static void Require(bool condition, string contract)
{
    if (!condition) throw new InvalidOperationException(contract);
}

sealed class ContractHandler : HttpMessageHandler
{
    public int Calls { get; private set; }
    public string? LastBody { get; private set; }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Calls++;
        if (request.Method != HttpMethod.Post || request.RequestUri?.AbsolutePath != "/v1/messages")
            throw new InvalidOperationException("Unexpected offline endpoint");
        if (!request.Headers.TryGetValues("x-api-key", out var keys) || keys.Single() != "offline" ||
            !request.Headers.TryGetValues("anthropic-version", out var versions) || versions.Single() != "2023-06-01" ||
            !request.Headers.TryGetValues("x-consumer-header", out var headers) || headers.Single() != "preserved")
            throw new InvalidOperationException("Caller headers/authentication were not preserved");
        LastBody = await request.Content!.ReadAsStringAsync(cancellationToken);
        using var body = JsonDocument.Parse(LastBody);
        if (body.RootElement.GetProperty("messages").GetArrayLength() != 1 ||
            body.RootElement.GetProperty("model").GetString() != "fixture" ||
            body.RootElement.GetProperty("max_tokens").GetInt32() != 32)
            throw new InvalidOperationException("Nonempty request contract");

#if PROBE_ErrorString || PROBE_ErrorStream
        var response = new HttpResponseMessage(HttpStatusCode.BadRequest)
        {
            Content = new StringContent("""{"type":"error","request_id":"req_fixture","error":{"type":"invalid_request_error","message":"fixture error"}}""", Encoding.UTF8, "application/json"),
        };
        response.Headers.Add("x-request-id", "req_fixture");
        return response;
#else
        var stream = body.RootElement.TryGetProperty("stream", out var streaming) && streaming.ValueKind == JsonValueKind.True;
#if PROBE_Stream || PROBE_TypedStream || PROBE_CustomStream
        if (!stream) throw new InvalidOperationException("Streaming request flag");
#endif
        var content = stream
            ? "event: content_block_delta\ndata: {\"type\":\"content_block_delta\",\"index\":0,\"delta\":{\"type\":\"text_delta\",\"text\":\"pong\"}}\n\nevent: message_stop\ndata: {\"type\":\"message_stop\"}\n\n"
#if PROBE_Tools || PROBE_CustomTools
            : """{"id":"msg_fixture","type":"message","role":"assistant","content":[{"type":"tool_use","caller":{"type":"direct"},"id":"call_fixture","name":"lookup","input":{"city":"Dubai"}}],"model":"fixture","stop_reason":"tool_use","stop_sequence":null,"usage":{"input_tokens":3,"output_tokens":2}}""";
#else
            : """{"id":"msg_fixture","type":"message","role":"assistant","content":[{"type":"text","text":"pong"}],"model":"fixture","stop_reason":"end_turn","stop_sequence":null,"usage":{"input_tokens":3,"output_tokens":2}}""";
#endif
        return new(HttpStatusCode.OK) { Content = new StringContent(content, Encoding.UTF8, stream ? "text/event-stream" : "application/json") };
#endif
    }
}

#if PROBE_Tools || PROBE_CustomTools
sealed class LookupFunction : Meai.AIFunction
{
    public override string Name => "lookup";
    public override string Description => "Lookup city";
    public override JsonElement JsonSchema
    {
        get
        {
            using var document = JsonDocument.Parse("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"],"additionalProperties":false,"minProperties":1}""");
            return document.RootElement.Clone();
        }
    }
    protected override ValueTask<object?> InvokeCoreAsync(Meai.AIFunctionArguments arguments, CancellationToken cancellationToken) => ValueTask.FromResult<object?>("unused");
}
#endif

#if PROBE_CustomStream || PROBE_CustomTools
sealed class ExplicitContext(JsonSerializerOptions options) : JsonSerializerContext(options)
{
    public static int RequestWrites;
    public static int EventReads;
    public static int MessageReads;
    public static int DictionaryReads;
    protected override JsonSerializerOptions? GeneratedSerializerOptions => null;
    public override JsonTypeInfo? GetTypeInfo(Type type) =>
        type == typeof(CreateMessageParams) ? JsonMetadataServices.CreateValueInfo<CreateMessageParams>(Options, new RequestConverter()) :
        type == typeof(MessageStreamEvent) ? JsonMetadataServices.CreateValueInfo<MessageStreamEvent>(Options, new EventConverter()) :
        type == typeof(Message) ? JsonMetadataServices.CreateValueInfo<Message>(Options, new MessageConverter()) :
        type == typeof(Dictionary<string, object?>) ? JsonMetadataServices.CreateValueInfo<Dictionary<string, object?>>(Options, new ArgumentsConverter()) : null;
}
sealed class RequestConverter : JsonConverter<CreateMessageParams>
{
    public override CreateMessageParams? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotSupportedException();
    public override void Write(Utf8JsonWriter writer, CreateMessageParams value, JsonSerializerOptions options)
    {
        ExplicitContext.RequestWrites++;
        writer.WriteRawValue(value.ToJson());
    }
}
sealed class EventConverter : JsonConverter<MessageStreamEvent>
{
    public override MessageStreamEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        ExplicitContext.EventReads++;
        using var document = JsonDocument.ParseValue(ref reader);
        return MessageStreamEvent.FromJson(document.RootElement.GetRawText()) ?? throw new JsonException();
    }
    public override void Write(Utf8JsonWriter writer, MessageStreamEvent value, JsonSerializerOptions options) => throw new NotSupportedException();
}
sealed class MessageConverter : JsonConverter<Message>
{
    public override Message? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        ExplicitContext.MessageReads++;
        using var document = JsonDocument.ParseValue(ref reader);
        return Message.FromJson(document.RootElement.GetRawText()) ?? throw new JsonException();
    }
    public override void Write(Utf8JsonWriter writer, Message value, JsonSerializerOptions options) => throw new NotSupportedException();
}
sealed class ArgumentsConverter : JsonConverter<Dictionary<string, object?>>
{
    public override Dictionary<string, object?>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        ExplicitContext.DictionaryReads++;
        using var document = JsonDocument.ParseValue(ref reader);
        return new() { ["city"] = document.RootElement.GetProperty("city").GetString() + "-custom" };
    }
    public override void Write(Utf8JsonWriter writer, Dictionary<string, object?> value, JsonSerializerOptions options) => throw new NotSupportedException();
}
#endif
