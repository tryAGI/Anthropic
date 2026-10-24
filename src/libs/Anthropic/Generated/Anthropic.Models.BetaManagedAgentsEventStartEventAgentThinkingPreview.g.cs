
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
        /// <default>"agent.thinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent.thinking";

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
            string type = "agent.thinking")
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

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsEventStartEventAgentThinkingPreview"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsEventStartEventAgentThinkingPreview FromId(string id)
        {
            return new BetaManagedAgentsEventStartEventAgentThinkingPreview
            {
                Id = id,
            };
        }

    }
}