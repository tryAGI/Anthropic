
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model will use any available tools.
    /// </summary>
    public sealed partial class ToolChoiceAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolChoiceAnyTypeJsonConverter))]
        public global::Anthropic.ToolChoiceAnyType Type { get; set; }

        /// <summary>
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_parallel_tool_use")]
        public bool? DisableParallelToolUse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAny" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="disableParallelToolUse">
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolChoiceAny(
            global::Anthropic.ToolChoiceAnyType type,
            bool? disableParallelToolUse)
        {
            this.Type = type;
            this.DisableParallelToolUse = disableParallelToolUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAny" /> class.
        /// </summary>
        public ToolChoiceAny()
        {
        }
    }
}