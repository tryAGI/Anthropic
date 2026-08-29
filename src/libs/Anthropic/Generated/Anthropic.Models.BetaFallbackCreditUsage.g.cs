
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Outcome of the ``fallback_credit_token`` presented on this request.
    /// </summary>
    public sealed partial class BetaFallbackCreditUsage
    {
        /// <summary>
        /// Whether the fallback-credit reprice was applied to this response's billing.<br/>
        /// A union discriminated on `type`. `redeemed`: the retry is billed as if<br/>
        /// the conversation had been on the retry model all along — including when the<br/>
        /// resulting shift is zero because there was nothing to move. `not_applied`:<br/>
        /// no reprice was applied; the arm's `reason` says why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Status Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditUsage" /> class.
        /// </summary>
        /// <param name="status">
        /// Whether the fallback-credit reprice was applied to this response's billing.<br/>
        /// A union discriminated on `type`. `redeemed`: the retry is billed as if<br/>
        /// the conversation had been on the retry model all along — including when the<br/>
        /// resulting shift is zero because there was nothing to move. `not_applied`:<br/>
        /// no reprice was applied; the arm's `reason` says why.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFallbackCreditUsage(
            global::Anthropic.Status status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditUsage" /> class.
        /// </summary>
        public BetaFallbackCreditUsage()
        {
        }

    }
}