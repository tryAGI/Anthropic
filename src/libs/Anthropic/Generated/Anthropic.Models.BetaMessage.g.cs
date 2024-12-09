
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessage
    {
        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: msg_013Zva2CMHLNnXjNJJKqJ2EF
        /// </summary>
        /// <example>msg_013Zva2CMHLNnXjNJJKqJ2EF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Messages, this is always `"message"`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::Anthropic.BetaMessageType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMessageTypeJsonConverter))]
        public global::Anthropic.BetaMessageType Type { get; set; } = global::Anthropic.BetaMessageType.Message;

        /// <summary>
        /// Conversational role of the generated message.<br/>
        /// This will always be `"assistant"`.<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::Anthropic.BetaMessageRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMessageRoleJsonConverter))]
        public global::Anthropic.BetaMessageRole Role { get; set; } = global::Anthropic.BetaMessageRole.Assistant;

        /// <summary>
        /// Content generated by the model.<br/>
        /// This is an array of content blocks, each of which has a `type` that determines its shape.<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// [{"type": "text", "text": "Hi, I'm Claude."}]<br/>
        /// ```<br/>
        /// If the request input `messages` ended with an `assistant` turn, then the response `content` will continue directly from that last turn. You can use this to constrain the model's output.<br/>
        /// For example, if the input `messages` were:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun"},<br/>
        ///   {"role": "assistant", "content": "The best answer is ("}<br/>
        /// ]<br/>
        /// ```<br/>
        /// Then the response `content` might be:<br/>
        /// ```json<br/>
        /// [{"type": "text", "text": "B)"}]<br/>
        /// ```<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock> Content { get; set; }

        /// <summary>
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Model Model { get; set; }

        /// <summary>
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// * `"end_turn"`: the model reached a natural stopping point<br/>
        /// * `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
        /// * `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
        /// * `"tool_use"`: the model invoked one or more tools<br/>
        /// In non-streaming mode this value is always non-null. In streaming mode, it is null in the `message_start` event and non-null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMessageStopReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaMessageStopReason? StopReason { get; set; }

        /// <summary>
        /// Which custom stop sequence was generated, if any.<br/>
        /// This value will be a non-null string if one of your custom stop sequences was generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? StopSequence { get; set; }

        /// <summary>
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: msg_013Zva2CMHLNnXjNJJKqJ2EF
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Messages, this is always `"message"`.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// Conversational role of the generated message.<br/>
        /// This will always be `"assistant"`.<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="content">
        /// Content generated by the model.<br/>
        /// This is an array of content blocks, each of which has a `type` that determines its shape.<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// [{"type": "text", "text": "Hi, I'm Claude."}]<br/>
        /// ```<br/>
        /// If the request input `messages` ended with an `assistant` turn, then the response `content` will continue directly from that last turn. You can use this to constrain the model's output.<br/>
        /// For example, if the input `messages` were:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun"},<br/>
        ///   {"role": "assistant", "content": "The best answer is ("}<br/>
        /// ]<br/>
        /// ```<br/>
        /// Then the response `content` might be:<br/>
        /// ```json<br/>
        /// [{"type": "text", "text": "B)"}]<br/>
        /// ```<br/>
        /// Example: []
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="stopReason">
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// * `"end_turn"`: the model reached a natural stopping point<br/>
        /// * `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
        /// * `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
        /// * `"tool_use"`: the model invoked one or more tools<br/>
        /// In non-streaming mode this value is always non-null. In streaming mode, it is null in the `message_start` event and non-null otherwise.
        /// </param>
        /// <param name="stopSequence">
        /// Which custom stop sequence was generated, if any.<br/>
        /// This value will be a non-null string if one of your custom stop sequences was generated.
        /// </param>
        /// <param name="usage">
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaMessage(
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock> content,
            global::Anthropic.Model model,
            global::Anthropic.BetaMessageStopReason? stopReason,
            string? stopSequence,
            global::Anthropic.BetaUsage usage,
            global::Anthropic.BetaMessageType type = global::Anthropic.BetaMessageType.Message,
            global::Anthropic.BetaMessageRole role = global::Anthropic.BetaMessageRole.Assistant)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Model = model;
            this.StopReason = stopReason;
            this.StopSequence = stopSequence ?? throw new global::System.ArgumentNullException(nameof(stopSequence));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Type = type;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessage" /> class.
        /// </summary>
        public BetaMessage()
        {
        }
    }
}