
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Delivery event written to the target thread's input stream when an agent-to-agent message arrives.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentThreadMessageReceivedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentThreadMessageReceivedEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the message was received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Name of the callable agent this message came from. Absent when received from the primary agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_agent_name")]
        public string? FromAgentName { get; set; }

        /// <summary>
        /// Message content blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> Content { get; set; }

        /// <summary>
        /// Public `sthr_` ID of the thread that sent the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_session_thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromSessionThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentThreadMessageReceivedEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when the message was received.
        /// </param>
        /// <param name="content">
        /// Message content blocks.
        /// </param>
        /// <param name="fromSessionThreadId">
        /// Public `sthr_` ID of the thread that sent the message.
        /// </param>
        /// <param name="type"></param>
        /// <param name="fromAgentName">
        /// Name of the callable agent this message came from. Absent when received from the primary agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentThreadMessageReceivedEvent(
            string id,
            global::System.DateTime processedAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> content,
            string fromSessionThreadId,
            global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEventType type,
            string? fromAgentName)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.FromAgentName = fromAgentName;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FromSessionThreadId = fromSessionThreadId ?? throw new global::System.ArgumentNullException(nameof(fromSessionThreadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentThreadMessageReceivedEvent" /> class.
        /// </summary>
        public BetaManagedAgentsAgentThreadMessageReceivedEvent()
        {
        }

    }
}