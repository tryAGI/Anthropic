
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseComputerMiddleClickToolUseBlock
    {
        /// <summary>
        /// Which party invoked the tool call: the model directly, or a server tool on its behalf.<br/>
        /// Default Value: {"type":"direct"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolUseCallerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ToolUseCaller Caller { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Click the middle mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ComputerMiddleClickInput Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"middle_click"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "middle_click";

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
        /// Initializes a new instance of the <see cref="ResponseComputerMiddleClickToolUseBlock" /> class.
        /// </summary>
        /// <param name="caller">
        /// Which party invoked the tool call: the model directly, or a server tool on its behalf.<br/>
        /// Default Value: {"type":"direct"}
        /// </param>
        /// <param name="id"></param>
        /// <param name="input">
        /// Click the middle mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </param>
        /// <param name="name"></param>
        /// <param name="toolsetName"></param>
        /// <param name="type">
        /// Default Value: tool_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseComputerMiddleClickToolUseBlock(
            global::Anthropic.ToolUseCaller caller,
            string id,
            global::Anthropic.ComputerMiddleClickInput input,
            string name = "middle_click",
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
        /// Initializes a new instance of the <see cref="ResponseComputerMiddleClickToolUseBlock" /> class.
        /// </summary>
        public ResponseComputerMiddleClickToolUseBlock()
        {
        }

    }
}