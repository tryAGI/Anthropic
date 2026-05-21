
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Statistics about the work queue for an environment.<br/>
    /// Uses Redis Stream consumer group metrics for O(1) queries.
    /// </summary>
    public sealed partial class BetaSelfHostedWorkQueueStats
    {
        /// <summary>
        /// Number of work items waiting to be picked up (lag from consumer group)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Depth { get; set; }

        /// <summary>
        /// RFC 3339 timestamp of oldest item in the work stream (includes both queued and pending items), null if stream empty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldest_queued_at")]
        public string? OldestQueuedAt { get; set; }

        /// <summary>
        /// Number of work items being processed (polled but not acknowledged)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pending { get; set; }

        /// <summary>
        /// The type of object<br/>
        /// Default Value: work_queue_stats
        /// </summary>
        /// <default>"work_queue_stats"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "work_queue_stats";

        /// <summary>
        /// Number of workers that have polled for work in the last 30 seconds. Requires worker_id to be sent with poll requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workers_polling")]
        public int? WorkersPolling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWorkQueueStats" /> class.
        /// </summary>
        /// <param name="depth">
        /// Number of work items waiting to be picked up (lag from consumer group)
        /// </param>
        /// <param name="pending">
        /// Number of work items being processed (polled but not acknowledged)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="oldestQueuedAt">
        /// RFC 3339 timestamp of oldest item in the work stream (includes both queued and pending items), null if stream empty
        /// </param>
        /// <param name="workersPolling">
        /// Number of workers that have polled for work in the last 30 seconds. Requires worker_id to be sent with poll requests.
        /// </param>
        /// <param name="type">
        /// The type of object<br/>
        /// Default Value: work_queue_stats
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSelfHostedWorkQueueStats(
            int depth,
            int pending,
            string? oldestQueuedAt,
            int? workersPolling,
            string type = "work_queue_stats")
        {
            this.Depth = depth;
            this.OldestQueuedAt = oldestQueuedAt;
            this.Pending = pending;
            this.Type = type;
            this.WorkersPolling = workersPolling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWorkQueueStats" /> class.
        /// </summary>
        public BetaSelfHostedWorkQueueStats()
        {
        }

    }
}