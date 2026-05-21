
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Emitted when a subagent is spawned as a new thread. Written to the parent thread's output stream so clients observing the session see child creation.<br/>
    /// Example: {"type":"session.thread_created","id":"sevt_011CZkZWXb7pJkx1shYaqoCu","session_thread_id":"sthr_011CZkZVWa6oIjw0rgXZpnBt","processed_at":"2026-03-15T10:00:00Z","agent_name":"Researcher"}
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadCreatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionThreadCreatedEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the thread was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Name of the callable agent the thread runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Public `sthr_` ID of the newly created thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadCreatedEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when the thread was created.
        /// </param>
        /// <param name="agentName">
        /// Name of the callable agent the thread runs.
        /// </param>
        /// <param name="sessionThreadId">
        /// Public `sthr_` ID of the newly created thread.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionThreadCreatedEvent(
            string id,
            global::System.DateTime processedAt,
            string agentName,
            string sessionThreadId,
            global::Anthropic.BetaManagedAgentsSessionThreadCreatedEventType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.SessionThreadId = sessionThreadId ?? throw new global::System.ArgumentNullException(nameof(sessionThreadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadCreatedEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSessionThreadCreatedEvent()
        {
        }

    }
}