
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Accepted/rejected counts for a single Claude Code tool type.
    /// </summary>
    public sealed partial class BetaAnalyticsToolActionCounts
    {
        /// <summary>
        /// Number of tool proposals accepted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AcceptedCount { get; set; }

        /// <summary>
        /// Number of tool proposals rejected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RejectedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsToolActionCounts" /> class.
        /// </summary>
        /// <param name="acceptedCount">
        /// Number of tool proposals accepted
        /// </param>
        /// <param name="rejectedCount">
        /// Number of tool proposals rejected
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsToolActionCounts(
            int acceptedCount,
            int rejectedCount)
        {
            this.AcceptedCount = acceptedCount;
            this.RejectedCount = rejectedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsToolActionCounts" /> class.
        /// </summary>
        public BetaAnalyticsToolActionCounts()
        {
        }

    }
}