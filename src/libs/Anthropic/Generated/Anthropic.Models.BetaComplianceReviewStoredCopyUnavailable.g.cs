
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A copy of the message was stored and can't be returned.
    /// </summary>
    public sealed partial class BetaComplianceReviewStoredCopyUnavailable
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"stored_copy_unavailable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stored_copy_unavailable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewStoredCopyUnavailable" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewStoredCopyUnavailable(
            string type = "stored_copy_unavailable")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewStoredCopyUnavailable" /> class.
        /// </summary>
        public BetaComplianceReviewStoredCopyUnavailable()
        {
        }

    }
}