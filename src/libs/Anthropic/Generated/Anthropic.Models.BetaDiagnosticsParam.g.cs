
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request-level diagnostics. Currently carries the previous response<br/>
    /// id for prompt-cache divergence reporting.
    /// </summary>
    public sealed partial class BetaDiagnosticsParam
    {
        /// <summary>
        /// The `id` (`msg_...`) from this client's previous /v1/messages response. The server compares that request's prompt fingerprint against this one and returns `diagnostics.cache_miss_reason` when the prompt-cache prefix could not be reused. Pass `null` on the first turn to opt in without a prior message to compare.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_message_id")]
        public string? PreviousMessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDiagnosticsParam" /> class.
        /// </summary>
        /// <param name="previousMessageId">
        /// The `id` (`msg_...`) from this client's previous /v1/messages response. The server compares that request's prompt fingerprint against this one and returns `diagnostics.cache_miss_reason` when the prompt-cache prefix could not be reused. Pass `null` on the first turn to opt in without a prior message to compare.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDiagnosticsParam(
            string? previousMessageId)
        {
            this.PreviousMessageId = previousMessageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDiagnosticsParam" /> class.
        /// </summary>
        public BetaDiagnosticsParam()
        {
        }

    }
}