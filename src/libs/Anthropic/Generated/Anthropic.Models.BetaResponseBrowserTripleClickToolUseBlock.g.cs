
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponseBrowserTripleClickToolUseBlock
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
        /// Triple left-click at a viewport coordinate or on an element by reference<br/>
        /// (typically selects a line or paragraph).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaBrowserTripleClickInput Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"triple_click"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "triple_click";

        /// <summary>
        ///
        /// </summary>
        /// <default>"browser"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolset_name")]
        public string ToolsetName { get; set; } = "browser";

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
        /// Initializes a new instance of the <see cref="BetaResponseBrowserTripleClickToolUseBlock" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input">
        /// Triple left-click at a viewport coordinate or on an element by reference<br/>
        /// (typically selects a line or paragraph).
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
        public BetaResponseBrowserTripleClickToolUseBlock(
            string id,
            global::Anthropic.BetaBrowserTripleClickInput input,
            global::Anthropic.BetaToolUseCaller? caller,
            string name = "triple_click",
            string toolsetName = "browser",
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
        /// Initializes a new instance of the <see cref="BetaResponseBrowserTripleClickToolUseBlock" /> class.
        /// </summary>
        public BetaResponseBrowserTripleClickToolUseBlock()
        {
        }

    }
}