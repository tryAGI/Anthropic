
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model will use the specified tool with `tool_choice.name`.
    /// </summary>
    public sealed partial class ToolChoiceTool
    {
        /// <summary>
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_parallel_tool_use")]
        public bool? DisableParallelToolUse { get; set; }

        /// <summary>
        /// The name of the tool to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolChoiceToolTypeJsonConverter))]
        public global::Anthropic.ToolChoiceToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceTool" /> class.
        /// </summary>
        /// <param name="disableParallelToolUse">
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
        /// </param>
        /// <param name="name">
        /// The name of the tool to use.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceTool(
            string name,
            bool? disableParallelToolUse,
            global::Anthropic.ToolChoiceToolType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisableParallelToolUse = disableParallelToolUse;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceTool" /> class.
        /// </summary>
        public ToolChoiceTool()
        {
        }
    }
}