
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic flagged the item for your organization to review.
    /// </summary>
    public sealed partial class BetaComplianceReviewSafeguardsReason
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"safeguards_review"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "safeguards_review";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewSafeguardsReason" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewSafeguardsReason(
            string type = "safeguards_review")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewSafeguardsReason" /> class.
        /// </summary>
        public BetaComplianceReviewSafeguardsReason()
        {
        }

    }
}