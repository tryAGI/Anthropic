
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 5-field POSIX cron schedule with computed runtime timestamps.<br/>
    /// Example: {"type":"cron","expression":"0 9 * * 1-5","timezone":"America/Los_Angeles","last_run_at":"2026-03-16T16:00:09Z","upcoming_runs_at":["2026-03-17T16:00:00Z","2026-03-18T16:00:00Z"]}
    /// </summary>
    public sealed partial class BetaManagedAgentsCronSchedule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCronScheduleTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCronScheduleType Type { get; set; }

        /// <summary>
        /// 5-field POSIX cron expression: minute hour day-of-month month day-of-week (e.g., "0 9 * * 1-5" for weekdays at 9am). Day-of-week is 0-7 where 0 and 7 both mean Sunday. Extended cron syntax - seconds or year fields, and the special characters L, W, #, and ? - is not supported, nor are predefined shortcuts (@daily).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        /// IANA timezone identifier (e.g., "America/Los_Angeles", "UTC").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Time the most recent scheduled run actually started. Null until one completes; preserved after the deployment is archived. Manual runs do not update this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// Up to 5 timestamps of upcoming cron occurrences. Non-empty for active and paused deployments (reflects what the schedule would do if unpaused); empty once the deployment is archived (`archived_at` set). Each fire is offset by a small per-schedule jitter, so a run will actually start at or shortly after its listed time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upcoming_runs_at")]
        public global::System.Collections.Generic.IList<global::System.DateTime>? UpcomingRunsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCronSchedule" /> class.
        /// </summary>
        /// <param name="expression">
        /// 5-field POSIX cron expression: minute hour day-of-month month day-of-week (e.g., "0 9 * * 1-5" for weekdays at 9am). Day-of-week is 0-7 where 0 and 7 both mean Sunday. Extended cron syntax - seconds or year fields, and the special characters L, W, #, and ? - is not supported, nor are predefined shortcuts (@daily).
        /// </param>
        /// <param name="timezone">
        /// IANA timezone identifier (e.g., "America/Los_Angeles", "UTC").
        /// </param>
        /// <param name="type"></param>
        /// <param name="lastRunAt">
        /// Time the most recent scheduled run actually started. Null until one completes; preserved after the deployment is archived. Manual runs do not update this.
        /// </param>
        /// <param name="upcomingRunsAt">
        /// Up to 5 timestamps of upcoming cron occurrences. Non-empty for active and paused deployments (reflects what the schedule would do if unpaused); empty once the deployment is archived (`archived_at` set). Each fire is offset by a small per-schedule jitter, so a run will actually start at or shortly after its listed time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCronSchedule(
            string expression,
            string timezone,
            global::Anthropic.BetaManagedAgentsCronScheduleType type,
            global::System.DateTime? lastRunAt,
            global::System.Collections.Generic.IList<global::System.DateTime>? upcomingRunsAt)
        {
            this.Type = type;
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.LastRunAt = lastRunAt;
            this.UpcomingRunsAt = upcomingRunsAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCronSchedule" /> class.
        /// </summary>
        public BetaManagedAgentsCronSchedule()
        {
        }

    }
}