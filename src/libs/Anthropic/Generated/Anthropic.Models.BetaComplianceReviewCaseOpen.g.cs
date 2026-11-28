
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic is waiting for a response to the case.
    /// </summary>
    public sealed partial class BetaComplianceReviewCaseOpen
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"open"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "open";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCaseOpen" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewCaseOpen(
            string type = "open")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCaseOpen" /> class.
        /// </summary>
        public BetaComplianceReviewCaseOpen()
        {
        }

    }
}