
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude Science activity metrics for a single user on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsScienceMetrics
    {
        /// <summary>
        /// Number of delegations (handoffs to a specialized agent) in Claude Science sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DelegationCount { get; set; }

        /// <summary>
        /// Number of distinct Claude Science sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_count")]
        public int? DistinctSessionCount { get; set; }

        /// <summary>
        /// Number of messages sent in Claude Science sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// Number of remote compute jobs launched from Claude Science sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_compute_job_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemoteComputeJobCount { get; set; }

        /// <summary>
        /// Total number of skill invocations in Claude Science sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SkillsUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsScienceMetrics" /> class.
        /// </summary>
        /// <param name="delegationCount">
        /// Number of delegations (handoffs to a specialized agent) in Claude Science sessions
        /// </param>
        /// <param name="messageCount">
        /// Number of messages sent in Claude Science sessions
        /// </param>
        /// <param name="remoteComputeJobCount">
        /// Number of remote compute jobs launched from Claude Science sessions
        /// </param>
        /// <param name="skillsUsedCount">
        /// Total number of skill invocations in Claude Science sessions
        /// </param>
        /// <param name="distinctSessionCount">
        /// Number of distinct Claude Science sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsScienceMetrics(
            int delegationCount,
            int messageCount,
            int remoteComputeJobCount,
            int skillsUsedCount,
            int? distinctSessionCount)
        {
            this.DelegationCount = delegationCount;
            this.DistinctSessionCount = distinctSessionCount;
            this.MessageCount = messageCount;
            this.RemoteComputeJobCount = remoteComputeJobCount;
            this.SkillsUsedCount = skillsUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsScienceMetrics" /> class.
        /// </summary>
        public BetaAnalyticsScienceMetrics()
        {
        }

    }
}