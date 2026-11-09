using System.Text.Json.Serialization;

namespace Anthropic;

// Tool arguments need only this dictionary, not the SDK-wide metadata graph.
[JsonSerializable(typeof(Dictionary<string, object?>))]
[JsonSerializable(typeof(JsonElement))]
internal sealed partial class ChatClientJsonSerializerContext : JsonSerializerContext;
