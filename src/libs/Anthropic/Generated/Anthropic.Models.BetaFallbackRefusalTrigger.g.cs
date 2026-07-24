
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `from` model declined for policy reasons.
    /// </summary>
    public sealed partial class BetaFallbackRefusalTrigger
    {
        /// <summary>
        /// The policy category that triggered the `from` model's refusal at this hop. `null` when the refusal doesn't map to a named category. Same vocabulary as `stop_details.category`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Anthropic.BetaRefusalCategory? Category { get; set; }

        /// <summary>
        /// Default Value: refusal
        /// </summary>
        /// <default>"refusal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "refusal";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackRefusalTrigger" /> class.
        /// </summary>
        /// <param name="category">
        /// The policy category that triggered the `from` model's refusal at this hop. `null` when the refusal doesn't map to a named category. Same vocabulary as `stop_details.category`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: refusal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFallbackRefusalTrigger(
            global::Anthropic.BetaRefusalCategory? category,
            string type = "refusal")
        {
            this.Category = category;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackRefusalTrigger" /> class.
        /// </summary>
        public BetaFallbackRefusalTrigger()
        {
        }

    }
}