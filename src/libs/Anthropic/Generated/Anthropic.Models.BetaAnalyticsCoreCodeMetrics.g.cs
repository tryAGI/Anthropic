
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Core Claude Code activity metrics for a single user on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsCoreCodeMetrics
    {
        /// <summary>
        /// Number of artifacts created in Claude Code sessions: an artifact counts once, on the day a session first saves it. Counted from 2026-08-17; 0 on earlier days. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ArtifactsCreatedCount { get; set; }

        /// <summary>
        /// Number of commits made via Claude Code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommitCount { get; set; }

        /// <summary>
        /// Number of distinct Claude Code sessions. On aggregated rows and in date-range mode: summed per-day distinct counts. A session essentially never spans a UTC day, so the sum is in practice the true distinct count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_count")]
        public int? DistinctSessionCount { get; set; }

        /// <summary>
        /// Lines of code added and removed via Claude Code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines_of_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsLinesOfCode LinesOfCode { get; set; }

        /// <summary>
        /// Number of pull requests created via Claude Code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PullRequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsCoreCodeMetrics" /> class.
        /// </summary>
        /// <param name="artifactsCreatedCount">
        /// Number of artifacts created in Claude Code sessions: an artifact counts once, on the day a session first saves it. Counted from 2026-08-17; 0 on earlier days. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="commitCount">
        /// Number of commits made via Claude Code
        /// </param>
        /// <param name="linesOfCode">
        /// Lines of code added and removed via Claude Code.
        /// </param>
        /// <param name="pullRequestCount">
        /// Number of pull requests created via Claude Code
        /// </param>
        /// <param name="distinctSessionCount">
        /// Number of distinct Claude Code sessions. On aggregated rows and in date-range mode: summed per-day distinct counts. A session essentially never spans a UTC day, so the sum is in practice the true distinct count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsCoreCodeMetrics(
            int artifactsCreatedCount,
            int commitCount,
            global::Anthropic.BetaAnalyticsLinesOfCode linesOfCode,
            int pullRequestCount,
            int? distinctSessionCount)
        {
            this.ArtifactsCreatedCount = artifactsCreatedCount;
            this.CommitCount = commitCount;
            this.DistinctSessionCount = distinctSessionCount;
            this.LinesOfCode = linesOfCode ?? throw new global::System.ArgumentNullException(nameof(linesOfCode));
            this.PullRequestCount = pullRequestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsCoreCodeMetrics" /> class.
        /// </summary>
        public BetaAnalyticsCoreCodeMetrics()
        {
        }

    }
}