
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponseComputerScrollToolUseBlock
    {
        /// <summary>
        /// Which party invoked the tool call: the model directly, or a server tool on its behalf.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaToolUseCallerJsonConverter))]
        public global::Anthropic.BetaToolUseCaller? Caller { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Scroll the screen at the specified (x, y) pixel coordinate, or the current cursor<br/>
        /// position if `coordinate` is omitted. Do NOT use PageUp/PageDown to scroll.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComputerScrollInput Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"scroll"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "scroll";

        /// <summary>
        ///
        /// </summary>
        /// <default>"computer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolset_name")]
        public string ToolsetName { get; set; } = "computer";

        /// <summary>
        /// Default Value: tool_use
        /// </summary>
        /// <default>"tool_use"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_use";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseComputerScrollToolUseBlock" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input">
        /// Scroll the screen at the specified (x, y) pixel coordinate, or the current cursor<br/>
        /// position if `coordinate` is omitted. Do NOT use PageUp/PageDown to scroll.
        /// </param>
        /// <param name="caller">
        /// Which party invoked the tool call: the model directly, or a server tool on its behalf.
        /// </param>
        /// <param name="name"></param>
        /// <param name="toolsetName"></param>
        /// <param name="type">
        /// Default Value: tool_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseComputerScrollToolUseBlock(
            string id,
            global::Anthropic.BetaComputerScrollInput input,
            global::Anthropic.BetaToolUseCaller? caller,
            string name = "scroll",
            string toolsetName = "computer",
            string type = "tool_use")
        {
            this.Caller = caller;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Name = name;
            this.ToolsetName = toolsetName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseComputerScrollToolUseBlock" /> class.
        /// </summary>
        public BetaResponseComputerScrollToolUseBlock()
        {
        }

    }
}