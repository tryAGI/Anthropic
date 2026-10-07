
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseComputerKeyToolUseBlock
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
        /// Press a key or key-combination on the keyboard. Use "+" to combine modifiers with<br/>
        /// a key (e.g. "ctrl+s", "alt+Tab", "ctrl+shift+Escape"). Key names are<br/>
        /// case-insensitive; common names like "Return", "Tab", "Escape", "Up", "Down",<br/>
        /// "Left", "Right", "Home", "End", "Page_Up", "Page_Down", "Delete", "BackSpace" are<br/>
        /// supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ComputerKeyInput Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"key"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "key";

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
        /// Initializes a new instance of the <see cref="ResponseComputerKeyToolUseBlock" /> class.
        /// </summary>
        /// <param name="caller">
        /// Which party invoked the tool call: the model directly, or a server tool on its behalf.<br/>
        /// Default Value: {"type":"direct"}
        /// </param>
        /// <param name="id"></param>
        /// <param name="input">
        /// Press a key or key-combination on the keyboard. Use "+" to combine modifiers with<br/>
        /// a key (e.g. "ctrl+s", "alt+Tab", "ctrl+shift+Escape"). Key names are<br/>
        /// case-insensitive; common names like "Return", "Tab", "Escape", "Up", "Down",<br/>
        /// "Left", "Right", "Home", "End", "Page_Up", "Page_Down", "Delete", "BackSpace" are<br/>
        /// supported.
        /// </param>
        /// <param name="name"></param>
        /// <param name="toolsetName"></param>
        /// <param name="type">
        /// Default Value: tool_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseComputerKeyToolUseBlock(
            global::Anthropic.ToolUseCaller caller,
            string id,
            global::Anthropic.ComputerKeyInput input,
            string name = "key",
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
        /// Initializes a new instance of the <see cref="ResponseComputerKeyToolUseBlock" /> class.
        /// </summary>
        public ResponseComputerKeyToolUseBlock()
        {
        }

    }
}