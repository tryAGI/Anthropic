
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseServerToolUseBlock
    {
        /// <summary>
        /// Default Value: {"type":"direct"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Caller13JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Anthropic.Caller13 Caller { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public object Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ResponseServerToolUseBlockNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Anthropic.ResponseServerToolUseBlockName Name { get; set; } = default!;

        /// <summary>
        /// Default Value: server_tool_use
        /// </summary>
        /// <default>"server_tool_use"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "server_tool_use";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseServerToolUseBlock" /> class.
        /// </summary>
        /// <param name="caller">
        /// Default Value: {"type":"direct"}
        /// </param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: server_tool_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseServerToolUseBlock(
            global::Anthropic.Caller13 caller,
            string id,
            object input,
            global::Anthropic.ResponseServerToolUseBlockName name,
            string type = "server_tool_use")
        {
            this.Caller = caller;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseServerToolUseBlock" /> class.
        /// </summary>
        public ResponseServerToolUseBlock()
        {
        }
    }
}