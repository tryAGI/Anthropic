
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsEventStartEventAgentThinkingPreview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventStartEventAgentThinkingPreviewTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreviewType Type { get; set; }

        /// <summary>
        /// The id the buffered agent.thinking will carry if it is emitted. Start-only — no event_delta events follow.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventStartEventAgentThinkingPreview" /> class.
        /// </summary>
        /// <param name="id">
        /// The id the buffered agent.thinking will carry if it is emitted. Start-only — no event_delta events follow.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEventStartEventAgentThinkingPreview(
            string id,
            global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreviewType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventStartEventAgentThinkingPreview" /> class.
        /// </summary>
        public BetaManagedAgentsEventStartEventAgentThinkingPreview()
        {
        }

    }
}