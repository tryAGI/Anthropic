
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Structured information about a refusal.
    /// </summary>
    public sealed partial class RefusalStopDetails
    {
        /// <summary>
        /// The policy category that triggered the refusal.<br/>
        /// `null` when the refusal doesn't map to a named category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Anthropic.RefusalStopDetailsCategory2? Category { get; set; }

        /// <summary>
        /// Human-readable explanation of the refusal.<br/>
        /// This text is not guaranteed to be stable. `null` when no explanation is available for the category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

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
        /// Initializes a new instance of the <see cref="RefusalStopDetails" /> class.
        /// </summary>
        /// <param name="category">
        /// The policy category that triggered the refusal.<br/>
        /// `null` when the refusal doesn't map to a named category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="explanation">
        /// Human-readable explanation of the refusal.<br/>
        /// This text is not guaranteed to be stable. `null` when no explanation is available for the category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: refusal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefusalStopDetails(
            global::Anthropic.RefusalStopDetailsCategory2? category,
            string? explanation,
            string type = "refusal")
        {
            this.Category = category;
            this.Explanation = explanation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefusalStopDetails" /> class.
        /// </summary>
        public RefusalStopDetails()
        {
        }
    }
}