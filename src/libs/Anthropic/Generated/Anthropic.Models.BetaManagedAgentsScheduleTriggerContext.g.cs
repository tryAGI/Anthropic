
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The run was fired by the deployment's cron schedule.
    /// </summary>
    public sealed partial class BetaManagedAgentsScheduleTriggerContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsScheduleTriggerContextTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContextType Type { get; set; }

        /// <summary>
        /// The UTC instant at which the cron expression matched in the configured timezone, before jitter is applied. At most one run is recorded per (deployment_id, scheduled_at) pair.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsScheduleTriggerContext" /> class.
        /// </summary>
        /// <param name="scheduledAt">
        /// The UTC instant at which the cron expression matched in the configured timezone, before jitter is applied. At most one run is recorded per (deployment_id, scheduled_at) pair.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsScheduleTriggerContext(
            global::System.DateTime scheduledAt,
            global::Anthropic.BetaManagedAgentsScheduleTriggerContextType type)
        {
            this.Type = type;
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsScheduleTriggerContext" /> class.
        /// </summary>
        public BetaManagedAgentsScheduleTriggerContext()
        {
        }

    }
}