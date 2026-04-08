
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An agent response event in the session conversation.<br/>
    /// Example: {"type":"agent.message","id":"sevt_011CZkZHPq1jCdq5lbRTjiVnz","content":[{"type":"text","text":"Let me look up order #1234 for you."}],"processed_at":"2026-03-15T10:00:00Z"}
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMessageEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentMessageEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Array of text blocks comprising the agent response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsTextBlock> Content { get; set; }

        /// <summary>
        /// Timestamp when this response was generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentMessageEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="content">
        /// Array of text blocks comprising the agent response.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when this response was generated.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentMessageEvent(
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsTextBlock> content,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsAgentMessageEventType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ProcessedAt = processedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentMessageEvent" /> class.
        /// </summary>
        public BetaManagedAgentsAgentMessageEvent()
        {
        }
    }
}