
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsEventStartEventAgentMessagePreview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventStartEventAgentMessagePreviewTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreviewType Type { get; set; }

        /// <summary>
        /// The id the buffered agent.message will carry if it is emitted. Matches the event_id on this preview's event_delta events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventStartEventAgentMessagePreview" /> class.
        /// </summary>
        /// <param name="id">
        /// The id the buffered agent.message will carry if it is emitted. Matches the event_id on this preview's event_delta events.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEventStartEventAgentMessagePreview(
            string id,
            global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreviewType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventStartEventAgentMessagePreview" /> class.
        /// </summary>
        public BetaManagedAgentsEventStartEventAgentMessagePreview()
        {
        }

    }
}