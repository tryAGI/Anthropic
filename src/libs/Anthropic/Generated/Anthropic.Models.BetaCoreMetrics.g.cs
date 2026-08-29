
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCoreMetrics
    {
        /// <summary>
        /// Number of git commits created through Claude Code's commit functionality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_by_claude_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommitsByClaudeCode { get; set; }

        /// <summary>
        /// Statistics on code changes made through Claude Code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines_of_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaLinesOfCode LinesOfCode { get; set; }

        /// <summary>
        /// Number of distinct Claude Code sessions initiated by this actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumSessions { get; set; }

        /// <summary>
        /// Number of pull requests created through Claude Code's PR functionality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests_by_claude_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PullRequestsByClaudeCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCoreMetrics" /> class.
        /// </summary>
        /// <param name="commitsByClaudeCode">
        /// Number of git commits created through Claude Code's commit functionality.
        /// </param>
        /// <param name="linesOfCode">
        /// Statistics on code changes made through Claude Code.
        /// </param>
        /// <param name="numSessions">
        /// Number of distinct Claude Code sessions initiated by this actor.
        /// </param>
        /// <param name="pullRequestsByClaudeCode">
        /// Number of pull requests created through Claude Code's PR functionality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCoreMetrics(
            int commitsByClaudeCode,
            global::Anthropic.BetaLinesOfCode linesOfCode,
            int numSessions,
            int pullRequestsByClaudeCode)
        {
            this.CommitsByClaudeCode = commitsByClaudeCode;
            this.LinesOfCode = linesOfCode ?? throw new global::System.ArgumentNullException(nameof(linesOfCode));
            this.NumSessions = numSessions;
            this.PullRequestsByClaudeCode = pullRequestsByClaudeCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCoreMetrics" /> class.
        /// </summary>
        public BetaCoreMetrics()
        {
        }

    }
}