
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Breakdown of output tokens by category.<br/>
    /// `output_tokens` remains the inclusive, authoritative total used for billing.<br/>
    /// This object provides a read-only decomposition for observability — for example,<br/>
    /// how many of the billed output tokens were spent on internal reasoning that may<br/>
    /// have been summarized before being returned to you.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class UsageOutputTokensDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}