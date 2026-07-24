
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A mid-conversation system message event. Carries system-role content that is appended to the session as a `role: "system"` turn.
    /// </summary>
    public sealed partial class BetaManagedAgentsSystemMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSystemMessageEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSystemMessageEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// System content blocks. Text-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock> Content { get; set; }

        /// <summary>
        /// Timestamp when this system message was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        public global::System.DateTime? ProcessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSystemMessageEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="content">
        /// System content blocks. Text-only.
        /// </param>
        /// <param name="type"></param>
        /// <param name="processedAt">
        /// Timestamp when this system message was processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSystemMessageEvent(
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock> content,
            global::Anthropic.BetaManagedAgentsSystemMessageEventType type,
            global::System.DateTime? processedAt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ProcessedAt = processedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSystemMessageEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSystemMessageEvent()
        {
        }

    }
}