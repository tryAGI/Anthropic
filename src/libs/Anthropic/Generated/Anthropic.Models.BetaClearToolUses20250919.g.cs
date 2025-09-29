
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaClearToolUses20250919
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_at_least")]
        public global::Anthropic.BetaInputTokensClearAtLeast? ClearAtLeast { get; set; }

        /// <summary>
        /// Whether to clear all tool inputs (bool) or specific tool inputs to clear (list)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_tool_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>))]
        public global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? ClearToolInputs { get; set; }

        /// <summary>
        /// Tool names whose uses are preserved from clearing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_tools")]
        public global::System.Collections.Generic.IList<string>? ExcludeTools { get; set; }

        /// <summary>
        /// Number of tool uses to retain in the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        public global::Anthropic.BetaToolUsesKeep? Keep { get; set; }

        /// <summary>
        /// Condition that triggers the context management strategy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.TriggerJsonConverter))]
        public global::Anthropic.Trigger? Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaClearToolUses20250919TypeJsonConverter))]
        public global::Anthropic.BetaClearToolUses20250919Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClearToolUses20250919" /> class.
        /// </summary>
        /// <param name="clearAtLeast"></param>
        /// <param name="clearToolInputs">
        /// Whether to clear all tool inputs (bool) or specific tool inputs to clear (list)
        /// </param>
        /// <param name="excludeTools">
        /// Tool names whose uses are preserved from clearing
        /// </param>
        /// <param name="keep">
        /// Number of tool uses to retain in the conversation
        /// </param>
        /// <param name="trigger">
        /// Condition that triggers the context management strategy
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClearToolUses20250919(
            global::Anthropic.BetaInputTokensClearAtLeast? clearAtLeast,
            global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? clearToolInputs,
            global::System.Collections.Generic.IList<string>? excludeTools,
            global::Anthropic.BetaToolUsesKeep? keep,
            global::Anthropic.Trigger? trigger,
            global::Anthropic.BetaClearToolUses20250919Type type)
        {
            this.ClearAtLeast = clearAtLeast;
            this.ClearToolInputs = clearToolInputs;
            this.ExcludeTools = excludeTools;
            this.Keep = keep;
            this.Trigger = trigger;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClearToolUses20250919" /> class.
        /// </summary>
        public BetaClearToolUses20250919()
        {
        }
    }
}