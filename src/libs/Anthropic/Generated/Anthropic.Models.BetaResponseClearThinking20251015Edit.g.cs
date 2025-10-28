
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseClearThinking20251015Edit
    {
        /// <summary>
        /// Number of input tokens cleared by this edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleared_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClearedInputTokens { get; set; }

        /// <summary>
        /// Number of thinking turns that were cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleared_thinking_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClearedThinkingTurns { get; set; }

        /// <summary>
        /// The type of context management edit applied.<br/>
        /// Default Value: clear_thinking_20251015
        /// </summary>
        /// <default>global::Anthropic.BetaResponseClearThinking20251015EditType.ClearThinking20251015</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseClearThinking20251015EditTypeJsonConverter))]
        public global::Anthropic.BetaResponseClearThinking20251015EditType Type { get; set; } = global::Anthropic.BetaResponseClearThinking20251015EditType.ClearThinking20251015;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseClearThinking20251015Edit" /> class.
        /// </summary>
        /// <param name="clearedInputTokens">
        /// Number of input tokens cleared by this edit.
        /// </param>
        /// <param name="clearedThinkingTurns">
        /// Number of thinking turns that were cleared.
        /// </param>
        /// <param name="type">
        /// The type of context management edit applied.<br/>
        /// Default Value: clear_thinking_20251015
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseClearThinking20251015Edit(
            int clearedInputTokens,
            int clearedThinkingTurns,
            global::Anthropic.BetaResponseClearThinking20251015EditType type = global::Anthropic.BetaResponseClearThinking20251015EditType.ClearThinking20251015)
        {
            this.ClearedInputTokens = clearedInputTokens;
            this.ClearedThinkingTurns = clearedThinkingTurns;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseClearThinking20251015Edit" /> class.
        /// </summary>
        public BetaResponseClearThinking20251015Edit()
        {
        }
    }
}