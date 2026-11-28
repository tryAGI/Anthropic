
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No copy of the message was stored.
    /// </summary>
    public sealed partial class BetaComplianceReviewContentNotCaptured
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"not_captured"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_captured";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewContentNotCaptured" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewContentNotCaptured(
            string type = "not_captured")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewContentNotCaptured" /> class.
        /// </summary>
        public BetaComplianceReviewContentNotCaptured()
        {
        }

    }
}