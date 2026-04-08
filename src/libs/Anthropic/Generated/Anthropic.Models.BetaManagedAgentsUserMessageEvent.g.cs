
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user message event in the session conversation.<br/>
    /// Example: {"type":"user.message","id":"sevt_011CZkZGOp0iBcp4kaQSihUmy","content":[{"type":"text","text":"Where is my order #1234?"}],"processed_at":"2026-03-15T10:00:00Z"}
    /// </summary>
    public sealed partial class BetaManagedAgentsUserMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserMessageEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserMessageEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Array of content blocks comprising the user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> Content { get; set; }

        /// <summary>
        /// Timestamp when the agent finished processing this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        public global::System.DateTime? ProcessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserMessageEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="content">
        /// Array of content blocks comprising the user message.
        /// </param>
        /// <param name="type"></param>
        /// <param name="processedAt">
        /// Timestamp when the agent finished processing this message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserMessageEvent(
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> content,
            global::Anthropic.BetaManagedAgentsUserMessageEventType type,
            global::System.DateTime? processedAt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ProcessedAt = processedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserMessageEvent" /> class.
        /// </summary>
        public BetaManagedAgentsUserMessageEvent()
        {
        }
    }
}