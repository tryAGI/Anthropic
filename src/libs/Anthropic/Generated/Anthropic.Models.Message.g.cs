
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A message in a chat conversation.
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.Block>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.OneOf<string, global::System.Collections.Generic.IList<global::Anthropic.Block>> Content { get; set; }

        /// <summary>
        /// The role of the messages author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.MessageRole Role { get; set; }

        /// <summary>
        /// The model that handled the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// - `"end_turn"`: the model reached a natural stopping point<br/>
        /// - `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
        /// - `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
        /// - `"tool_use"`: the model invoked one or more tools<br/>
        /// In non-streaming mode this value is always non-null. In streaming mode, it is<br/>
        /// null in the `message_start` event and non-null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.StopReasonJsonConverter))]
        public global::Anthropic.StopReason? StopReason { get; set; }

        /// <summary>
        /// Which custom stop sequence was generated, if any.<br/>
        /// This value will be a non-null string if one of your custom stop sequences was<br/>
        /// generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Messages, this is always `"message"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the<br/>
        /// underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the<br/>
        /// model. The model's output then goes through a parsing stage before becoming an<br/>
        /// API response. As a result, the token counts in `usage` will not match one-to-one<br/>
        /// with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response<br/>
        /// from Claude.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Anthropic.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author.
        /// </param>
        /// <param name="model">
        /// The model that handled the request.
        /// </param>
        /// <param name="stopReason">
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// - `"end_turn"`: the model reached a natural stopping point<br/>
        /// - `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
        /// - `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
        /// - `"tool_use"`: the model invoked one or more tools<br/>
        /// In non-streaming mode this value is always non-null. In streaming mode, it is<br/>
        /// null in the `message_start` event and non-null otherwise.
        /// </param>
        /// <param name="stopSequence">
        /// Which custom stop sequence was generated, if any.<br/>
        /// This value will be a non-null string if one of your custom stop sequences was<br/>
        /// generated.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Messages, this is always `"message"`.
        /// </param>
        /// <param name="usage">
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the<br/>
        /// underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the<br/>
        /// model. The model's output then goes through a parsing stage before becoming an<br/>
        /// API response. As a result, the token counts in `usage` will not match one-to-one<br/>
        /// with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response<br/>
        /// from Claude.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Message(
            global::Anthropic.OneOf<string, global::System.Collections.Generic.IList<global::Anthropic.Block>> content,
            global::Anthropic.MessageRole role,
            string? id,
            string? model,
            global::Anthropic.StopReason? stopReason,
            string? stopSequence,
            string? type,
            global::Anthropic.Usage? usage)
        {
            this.Content = content;
            this.Role = role;
            this.Id = id;
            this.Model = model;
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Type = type;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }
    }
}