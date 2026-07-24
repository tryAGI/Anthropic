
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The advisor sub-inference's stop reason (same values as the top-level message `stop_reason`). `max_tokens` indicates the advisor's output was truncated at the tool's `max_tokens` value or the advisor model's policy cap.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class BetaResponseAdvisorResultBlockStopReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}