
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Periodic snapshot of the session's cumulative usage and tracked list cost.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionUsageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionUsageEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionUsageEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the snapshot was taken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// The session's cumulative usage at the snapshot time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionUsageSnapshot Usage { get; set; }

        /// <summary>
        /// The session's configured budget at the snapshot time, or null when the session has no budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        public global::Anthropic.BetaManagedAgentsBudget? Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionUsageEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when the snapshot was taken.
        /// </param>
        /// <param name="usage">
        /// The session's cumulative usage at the snapshot time.
        /// </param>
        /// <param name="type"></param>
        /// <param name="budget">
        /// The session's configured budget at the snapshot time, or null when the session has no budget.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionUsageEvent(
            string id,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsSessionUsageSnapshot usage,
            global::Anthropic.BetaManagedAgentsSessionUsageEventType type,
            global::Anthropic.BetaManagedAgentsBudget? budget)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Budget = budget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionUsageEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSessionUsageEvent()
        {
        }

    }
}