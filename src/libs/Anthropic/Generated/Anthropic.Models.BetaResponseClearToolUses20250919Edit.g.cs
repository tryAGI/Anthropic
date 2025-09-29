
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Results for clear_tool_uses_20250919 edit.
    /// </summary>
    public sealed partial class BetaResponseClearToolUses20250919Edit
    {
        /// <summary>
        /// Number of input tokens cleared by this edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleared_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClearedInputTokens { get; set; }

        /// <summary>
        /// Number of tool uses that were cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleared_tool_uses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClearedToolUses { get; set; }

        /// <summary>
        /// The type of context management edit applied.<br/>
        /// Default Value: clear_tool_uses_20250919
        /// </summary>
        /// <default>global::Anthropic.BetaResponseClearToolUses20250919EditType.ClearToolUses20250919</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseClearToolUses20250919EditTypeJsonConverter))]
        public global::Anthropic.BetaResponseClearToolUses20250919EditType Type { get; set; } = global::Anthropic.BetaResponseClearToolUses20250919EditType.ClearToolUses20250919;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseClearToolUses20250919Edit" /> class.
        /// </summary>
        /// <param name="clearedInputTokens">
        /// Number of input tokens cleared by this edit.
        /// </param>
        /// <param name="clearedToolUses">
        /// Number of tool uses that were cleared.
        /// </param>
        /// <param name="type">
        /// The type of context management edit applied.<br/>
        /// Default Value: clear_tool_uses_20250919
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseClearToolUses20250919Edit(
            int clearedInputTokens,
            int clearedToolUses,
            global::Anthropic.BetaResponseClearToolUses20250919EditType type = global::Anthropic.BetaResponseClearToolUses20250919EditType.ClearToolUses20250919)
        {
            this.ClearedInputTokens = clearedInputTokens;
            this.ClearedToolUses = clearedToolUses;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseClearToolUses20250919Edit" /> class.
        /// </summary>
        public BetaResponseClearToolUses20250919Edit()
        {
        }
    }
}