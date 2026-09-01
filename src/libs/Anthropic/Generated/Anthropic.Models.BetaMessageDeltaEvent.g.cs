
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMessageDeltaEvent
    {
        /// <summary>
        /// Information about context management strategies applied during the request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        public global::Anthropic.BetaResponseContextManagement? ContextManagement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaMessageDelta Delta { get; set; }

        /// <summary>
        /// Changes the API made to the request's input before showing it to the model:<br/>
        /// one entry per change, in request order. Today the only entry type is<br/>
        /// `thinking_dropped` — a `thinking`, `redacted_thinking` or `connector_text`<br/>
        /// block from the request's `messages` that was removed from the prompt instead<br/>
        /// of being shown to the model because it failed a binding check. More entry<br/>
        /// types may be added over time; ignore types you do not recognize.<br/>
        /// Requires `anthropic-beta: thinking-binding-controls-2026-08-01`. Present on<br/>
        /// every such response from a model that supports extended thinking, as `[]`<br/>
        /// when nothing was changed; without the beta, blocks are removed all the same<br/>
        /// but nothing is reported. Removed blocks contribute nothing to<br/>
        /// `usage.input_tokens`. When streaming, the array is final in `message_start`;<br/>
        /// the final `message_delta` event carries it only when a server-side model<br/>
        /// fallback happened mid-stream, in which case it holds the serving model's<br/>
        /// entries and replaces the one in `message_start`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_transformations")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaThinkingDroppedInputTransformation>? InputTransformations { get; set; }

        /// <summary>
        /// Default Value: message_delta
        /// </summary>
        /// <default>"message_delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "message_delta";

        /// <summary>
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.<br/>
        /// Total input tokens in a request is the summation of `input_tokens`, `cache_creation_input_tokens`, and `cache_read_input_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaMessageDeltaUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="usage">
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.<br/>
        /// Total input tokens in a request is the summation of `input_tokens`, `cache_creation_input_tokens`, and `cache_read_input_tokens`.
        /// </param>
        /// <param name="contextManagement">
        /// Information about context management strategies applied during the request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inputTransformations">
        /// Changes the API made to the request's input before showing it to the model:<br/>
        /// one entry per change, in request order. Today the only entry type is<br/>
        /// `thinking_dropped` — a `thinking`, `redacted_thinking` or `connector_text`<br/>
        /// block from the request's `messages` that was removed from the prompt instead<br/>
        /// of being shown to the model because it failed a binding check. More entry<br/>
        /// types may be added over time; ignore types you do not recognize.<br/>
        /// Requires `anthropic-beta: thinking-binding-controls-2026-08-01`. Present on<br/>
        /// every such response from a model that supports extended thinking, as `[]`<br/>
        /// when nothing was changed; without the beta, blocks are removed all the same<br/>
        /// but nothing is reported. Removed blocks contribute nothing to<br/>
        /// `usage.input_tokens`. When streaming, the array is final in `message_start`;<br/>
        /// the final `message_delta` event carries it only when a server-side model<br/>
        /// fallback happened mid-stream, in which case it holds the serving model's<br/>
        /// entries and replaces the one in `message_start`.
        /// </param>
        /// <param name="type">
        /// Default Value: message_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessageDeltaEvent(
            global::Anthropic.BetaMessageDelta delta,
            global::Anthropic.BetaMessageDeltaUsage usage,
            global::Anthropic.BetaResponseContextManagement? contextManagement,
            global::System.Collections.Generic.IList<global::Anthropic.BetaThinkingDroppedInputTransformation>? inputTransformations,
            string type = "message_delta")
        {
            this.ContextManagement = contextManagement;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.InputTransformations = inputTransformations;
            this.Type = type;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageDeltaEvent" /> class.
        /// </summary>
        public BetaMessageDeltaEvent()
        {
        }

    }
}