
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Observability event emitted to the sender's output stream when an agent-to-agent message is sent.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentThreadMessageSentEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentThreadMessageSentEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the message was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Name of the callable agent this message was sent to. Absent when sent to the primary agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_agent_name")]
        public string? ToAgentName { get; set; }

        /// <summary>
        /// Message content blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> Content { get; set; }

        /// <summary>
        /// Public `sthr_` ID of the thread the message was sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_session_thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToSessionThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentThreadMessageSentEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when the message was sent.
        /// </param>
        /// <param name="content">
        /// Message content blocks.
        /// </param>
        /// <param name="toSessionThreadId">
        /// Public `sthr_` ID of the thread the message was sent to.
        /// </param>
        /// <param name="type"></param>
        /// <param name="toAgentName">
        /// Name of the callable agent this message was sent to. Absent when sent to the primary agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentThreadMessageSentEvent(
            string id,
            global::System.DateTime processedAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> content,
            string toSessionThreadId,
            global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEventType type,
            string? toAgentName)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.ToAgentName = toAgentName;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToSessionThreadId = toSessionThreadId ?? throw new global::System.ArgumentNullException(nameof(toSessionThreadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentThreadMessageSentEvent" /> class.
        /// </summary>
        public BetaManagedAgentsAgentThreadMessageSentEvent()
        {
        }
    }
}