
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Outcome of the `fallback_credit_token` presented on this request.<br/>
    /// Present on every response to a non-batch request that carried a<br/>
    /// `fallback_credit_token`, in either redemption mode; absent otherwise (batch<br/>
    /// items accept and ignore the token and carry no outcome object).<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class BetaUsageFallbackCredit
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}