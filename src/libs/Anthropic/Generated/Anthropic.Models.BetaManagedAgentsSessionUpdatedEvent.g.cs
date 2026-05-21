
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Emitted when an UpdateSession request changed at least one field. Carries only the fields that changed; absent fields were not part of the update. The new configuration applies from the next turn.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionUpdatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionUpdatedEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the update was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// The session's new title. Present only when the update changed it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The session's full metadata bag after the update. Present when the update set non-empty metadata; absent when metadata was unchanged or cleared to empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The session's effective agent configuration after the update. Present only when the update changed `agent` (tools or mcp_servers); when present it is the full materialised snapshot, not a diff.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Anthropic.BetaManagedAgentsSessionAgent? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionUpdatedEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when the update was applied.
        /// </param>
        /// <param name="type"></param>
        /// <param name="title">
        /// The session's new title. Present only when the update changed it.
        /// </param>
        /// <param name="metadata">
        /// The session's full metadata bag after the update. Present when the update set non-empty metadata; absent when metadata was unchanged or cleared to empty.
        /// </param>
        /// <param name="agent">
        /// The session's effective agent configuration after the update. Present only when the update changed `agent` (tools or mcp_servers); when present it is the full materialised snapshot, not a diff.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionUpdatedEvent(
            string id,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsSessionUpdatedEventType type,
            string? title,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::Anthropic.BetaManagedAgentsSessionAgent? agent)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.Title = title;
            this.Metadata = metadata;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionUpdatedEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSessionUpdatedEvent()
        {
        }

    }
}