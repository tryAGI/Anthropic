
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model will automatically decide whether to use tools.
    /// </summary>
    public sealed partial class ToolChoiceAuto
    {
        /// <summary>
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output at most one tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_parallel_tool_use")]
        public bool? DisableParallelToolUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolChoiceAutoTypeJsonConverter))]
        public global::Anthropic.ToolChoiceAutoType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAuto" /> class.
        /// </summary>
        /// <param name="disableParallelToolUse">
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output at most one tool use.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceAuto(
            bool? disableParallelToolUse,
            global::Anthropic.ToolChoiceAutoType type)
        {
            this.DisableParallelToolUse = disableParallelToolUse;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAuto" /> class.
        /// </summary>
        public ToolChoiceAuto()
        {
        }
    }
}