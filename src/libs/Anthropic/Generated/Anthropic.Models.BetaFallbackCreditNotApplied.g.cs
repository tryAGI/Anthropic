
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No reprice was applied; ``reason`` says why.
    /// </summary>
    public sealed partial class BetaFallbackCreditNotApplied
    {
        /// <summary>
        /// Why the reprice was not applied.<br/>
        /// A closed enum; additions to the redemption-check vocabulary arrive as<br/>
        /// deliberate schema updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaFallbackCreditNotAppliedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaFallbackCreditNotAppliedReason Reason { get; set; }

        /// <summary>
        /// Request fields to remove before retrying, so the retry can redeem this<br/>
        /// token.<br/>
        /// Present exactly when `reason` is `variant_fields_present` — never null,<br/>
        /// never an empty array; absent otherwise. Fields are named only from your own request, and only after<br/>
        /// the sealed variant hash matched. A served best-effort retry has already<br/>
        /// been billed at normal price; nothing redeems retroactively, but a corrected<br/>
        /// re-send inside the token's five-minute window can still redeem.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_to_redeem")]
        public global::System.Collections.Generic.IList<string>? RemoveToRedeem { get; set; }

        /// <summary>
        /// Default Value: not_applied
        /// </summary>
        /// <default>"not_applied"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_applied";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditNotApplied" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why the reprice was not applied.<br/>
        /// A closed enum; additions to the redemption-check vocabulary arrive as<br/>
        /// deliberate schema updates.
        /// </param>
        /// <param name="removeToRedeem">
        /// Request fields to remove before retrying, so the retry can redeem this<br/>
        /// token.<br/>
        /// Present exactly when `reason` is `variant_fields_present` — never null,<br/>
        /// never an empty array; absent otherwise. Fields are named only from your own request, and only after<br/>
        /// the sealed variant hash matched. A served best-effort retry has already<br/>
        /// been billed at normal price; nothing redeems retroactively, but a corrected<br/>
        /// re-send inside the token's five-minute window can still redeem.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: not_applied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFallbackCreditNotApplied(
            global::Anthropic.BetaFallbackCreditNotAppliedReason reason,
            global::System.Collections.Generic.IList<string>? removeToRedeem,
            string type = "not_applied")
        {
            this.Reason = reason;
            this.RemoveToRedeem = removeToRedeem;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditNotApplied" /> class.
        /// </summary>
        public BetaFallbackCreditNotApplied()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaFallbackCreditNotApplied"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaFallbackCreditNotApplied FromReason(global::Anthropic.BetaFallbackCreditNotAppliedReason reason)
        {
            return new BetaFallbackCreditNotApplied
            {
                Reason = reason,
            };
        }

    }
}