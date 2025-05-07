
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionResponse
    {
        /// <summary>
        /// The resulting completion up to and excluding the stop sequences.<br/>
        /// Example:  Hello! My name is Claude.
        /// </summary>
        /// <example> Hello! My name is Claude.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// * `"stop_sequence"`: we reached a stop sequence — either provided by you via the `stop_sequences` parameter, or a stop sequence built into the model<br/>
        /// * `"max_tokens"`: we exceeded `max_tokens_to_sample` or the model's maximum<br/>
        /// Example: stop_sequence
        /// </summary>
        /// <example>stop_sequence</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? StopReason { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Text Completions, this is always `"completion"`.<br/>
        /// Default Value: completion
        /// </summary>
        /// <default>global::Anthropic.CompletionResponseType.Completion</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CompletionResponseTypeJsonConverter))]
        public global::Anthropic.CompletionResponseType Type { get; set; } = global::Anthropic.CompletionResponseType.Completion;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        /// <param name="completion">
        /// The resulting completion up to and excluding the stop sequences.<br/>
        /// Example:  Hello! My name is Claude.
        /// </param>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="stopReason">
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// * `"stop_sequence"`: we reached a stop sequence — either provided by you via the `stop_sequences` parameter, or a stop sequence built into the model<br/>
        /// * `"max_tokens"`: we exceeded `max_tokens_to_sample` or the model's maximum<br/>
        /// Example: stop_sequence
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Text Completions, this is always `"completion"`.<br/>
        /// Default Value: completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionResponse(
            string completion,
            string id,
            global::Anthropic.Model model,
            string? stopReason,
            global::Anthropic.CompletionResponseType type = global::Anthropic.CompletionResponseType.Completion)
        {
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model;
            this.StopReason = stopReason ?? throw new global::System.ArgumentNullException(nameof(stopReason));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        public CompletionResponse()
        {
        }
    }
}