
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Timing statistics for a session.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionStats
    {
        /// <summary>
        /// Elapsed time since session creation in seconds. For terminated sessions, frozen at the final update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Cumulative time in seconds the session spent in running status. Excludes idle time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_seconds")]
        public double? ActiveSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionStats" /> class.
        /// </summary>
        /// <param name="durationSeconds">
        /// Elapsed time since session creation in seconds. For terminated sessions, frozen at the final update.
        /// </param>
        /// <param name="activeSeconds">
        /// Cumulative time in seconds the session spent in running status. Excludes idle time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionStats(
            double? durationSeconds,
            double? activeSeconds)
        {
            this.DurationSeconds = durationSeconds;
            this.ActiveSeconds = activeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionStats" /> class.
        /// </summary>
        public BetaManagedAgentsSessionStats()
        {
        }
    }
}