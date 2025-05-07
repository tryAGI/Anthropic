
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseRedactedThinkingBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Default Value: redacted_thinking
        /// </summary>
        /// <default>global::Anthropic.BetaResponseRedactedThinkingBlockType.RedactedThinking</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseRedactedThinkingBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseRedactedThinkingBlockType Type { get; set; } = global::Anthropic.BetaResponseRedactedThinkingBlockType.RedactedThinking;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// Default Value: redacted_thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseRedactedThinkingBlock(
            string data,
            global::Anthropic.BetaResponseRedactedThinkingBlockType type = global::Anthropic.BetaResponseRedactedThinkingBlockType.RedactedThinking)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseRedactedThinkingBlock" /> class.
        /// </summary>
        public BetaResponseRedactedThinkingBlock()
        {
        }
    }
}