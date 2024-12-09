
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageDeltaEvent
    {
        /// <summary>
        /// Default Value: message_delta
        /// </summary>
        /// <default>global::Anthropic.BetaMessageDeltaEventType.MessageDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMessageDeltaEventTypeJsonConverter))]
        public global::Anthropic.BetaMessageDeltaEventType Type { get; set; } = global::Anthropic.BetaMessageDeltaEventType.MessageDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaMessageDelta Delta { get; set; }

        /// <summary>
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.
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
        /// <param name="type">
        /// Default Value: message_delta
        /// </param>
        /// <param name="delta"></param>
        /// <param name="usage">
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaMessageDeltaEvent(
            global::Anthropic.BetaMessageDelta delta,
            global::Anthropic.BetaMessageDeltaUsage usage,
            global::Anthropic.BetaMessageDeltaEventType type = global::Anthropic.BetaMessageDeltaEventType.MessageDelta)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageDeltaEvent" /> class.
        /// </summary>
        public BetaMessageDeltaEvent()
        {
        }
    }
}