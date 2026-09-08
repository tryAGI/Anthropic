
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Timing statistics for a session thread.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadStats
    {
        /// <summary>
        /// Elapsed time since thread creation in seconds. For archived threads, frozen at the final update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Time in seconds for the thread to begin running. Zero for child threads, which start immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup_seconds")]
        public double? StartupSeconds { get; set; }

        /// <summary>
        /// Cumulative time in seconds the thread spent actively running. Excludes idle time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_seconds")]
        public double? ActiveSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadStats" /> class.
        /// </summary>
        /// <param name="durationSeconds">
        /// Elapsed time since thread creation in seconds. For archived threads, frozen at the final update.
        /// </param>
        /// <param name="startupSeconds">
        /// Time in seconds for the thread to begin running. Zero for child threads, which start immediately.
        /// </param>
        /// <param name="activeSeconds">
        /// Cumulative time in seconds the thread spent actively running. Excludes idle time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionThreadStats(
            double? durationSeconds,
            double? startupSeconds,
            double? activeSeconds)
        {
            this.DurationSeconds = durationSeconds;
            this.StartupSeconds = startupSeconds;
            this.ActiveSeconds = activeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadStats" /> class.
        /// </summary>
        public BetaManagedAgentsSessionThreadStats()
        {
        }

    }
}