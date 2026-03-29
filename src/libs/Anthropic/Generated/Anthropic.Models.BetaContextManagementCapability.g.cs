
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Context management capability details.
    /// </summary>
    public sealed partial class BetaContextManagementCapability
    {
        /// <summary>
        /// Whether the clear_thinking_20251015 strategy is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_thinking_20251015")]
        public global::Anthropic.BetaCapabilitySupport? ClearThinking20251015 { get; set; }

        /// <summary>
        /// Whether the clear_tool_uses_20250919 strategy is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_tool_uses_20250919")]
        public global::Anthropic.BetaCapabilitySupport? ClearToolUses20250919 { get; set; }

        /// <summary>
        /// Whether the compact_20260112 strategy is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_20260112")]
        public global::Anthropic.BetaCapabilitySupport? Compact20260112 { get; set; }

        /// <summary>
        /// Whether this capability is supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContextManagementCapability" /> class.
        /// </summary>
        /// <param name="supported">
        /// Whether this capability is supported by the model.
        /// </param>
        /// <param name="clearThinking20251015">
        /// Whether the clear_thinking_20251015 strategy is supported.
        /// </param>
        /// <param name="clearToolUses20250919">
        /// Whether the clear_tool_uses_20250919 strategy is supported.
        /// </param>
        /// <param name="compact20260112">
        /// Whether the compact_20260112 strategy is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContextManagementCapability(
            bool supported,
            global::Anthropic.BetaCapabilitySupport? clearThinking20251015,
            global::Anthropic.BetaCapabilitySupport? clearToolUses20250919,
            global::Anthropic.BetaCapabilitySupport? compact20260112)
        {
            this.ClearThinking20251015 = clearThinking20251015;
            this.ClearToolUses20250919 = clearToolUses20250919;
            this.Compact20260112 = compact20260112;
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContextManagementCapability" /> class.
        /// </summary>
        public BetaContextManagementCapability()
        {
        }
    }
}