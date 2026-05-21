
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An interrupt event that pauses agent execution and returns control to the user.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserInterruptEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserInterruptEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserInterruptEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the interrupt was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        public global::System.DateTime? ProcessedAt { get; set; }

        /// <summary>
        /// If absent, interrupts every non-archived thread in a multiagent session (or the primary alone in a single-agent session). If present, interrupts only the named thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_thread_id")]
        public string? SessionThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserInterruptEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="type"></param>
        /// <param name="processedAt">
        /// Timestamp when the interrupt was processed.
        /// </param>
        /// <param name="sessionThreadId">
        /// If absent, interrupts every non-archived thread in a multiagent session (or the primary alone in a single-agent session). If present, interrupts only the named thread.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserInterruptEvent(
            string id,
            global::Anthropic.BetaManagedAgentsUserInterruptEventType type,
            global::System.DateTime? processedAt,
            string? sessionThreadId)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.SessionThreadId = sessionThreadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserInterruptEvent" /> class.
        /// </summary>
        public BetaManagedAgentsUserInterruptEvent()
        {
        }

    }
}