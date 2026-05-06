
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A session thread has yielded and is awaiting input. Emitted on the thread's own stream and cross-posted to the primary stream for child threads.<br/>
    /// Example: {"type":"session.thread_status_idle","id":"sevt_011CZkZXYc8qKly2tiZbrpDv","session_thread_id":"sthr_011CZkZVWa6oIjw0rgXZpnBt","processed_at":"2026-03-15T10:00:00Z","agent_name":"Researcher","stop_reason":{"type":"end_turn"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadStatusIdleEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionThreadStatusIdleEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Public sthr_ ID of the thread that went idle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionThreadId { get; set; }

        /// <summary>
        /// Timestamp of the status transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Name of the agent the thread runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReason StopReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadStatusIdleEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="sessionThreadId">
        /// Public sthr_ ID of the thread that went idle.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp of the status transition.
        /// </param>
        /// <param name="agentName">
        /// Name of the agent the thread runs.
        /// </param>
        /// <param name="stopReason"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionThreadStatusIdleEvent(
            string id,
            string sessionThreadId,
            global::System.DateTime processedAt,
            string agentName,
            global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReason stopReason,
            global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionThreadId = sessionThreadId ?? throw new global::System.ArgumentNullException(nameof(sessionThreadId));
            this.ProcessedAt = processedAt;
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.StopReason = stopReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadStatusIdleEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSessionThreadStatusIdleEvent()
        {
        }
    }
}