
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApprovalMetrics
    {
        /// <summary>
        /// Number of tool action proposals that the user accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Accepted { get; set; }

        /// <summary>
        /// Number of tool action proposals that the user rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rejected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApprovalMetrics" /> class.
        /// </summary>
        /// <param name="accepted">
        /// Number of tool action proposals that the user accepted.
        /// </param>
        /// <param name="rejected">
        /// Number of tool action proposals that the user rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApprovalMetrics(
            int accepted,
            int rejected)
        {
            this.Accepted = accepted;
            this.Rejected = rejected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApprovalMetrics" /> class.
        /// </summary>
        public BetaApprovalMetrics()
        {
        }

    }
}