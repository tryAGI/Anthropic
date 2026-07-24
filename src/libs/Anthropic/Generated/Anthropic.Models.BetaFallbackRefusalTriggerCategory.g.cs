
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The policy category that triggered the `from` model's refusal at this hop. `null` when the refusal doesn't map to a named category. Same vocabulary as `stop_details.category`.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class BetaFallbackRefusalTriggerCategory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}