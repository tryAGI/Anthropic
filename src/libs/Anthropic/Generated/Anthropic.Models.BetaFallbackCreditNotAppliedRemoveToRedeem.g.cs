
#nullable enable

namespace Anthropic
{
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
    public sealed partial class BetaFallbackCreditNotAppliedRemoveToRedeem
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}