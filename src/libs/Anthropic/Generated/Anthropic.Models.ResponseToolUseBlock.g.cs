
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseToolUseBlock
    {
        /// <summary>
        /// Default Value: tool_use
        /// </summary>
        /// <default>global::Anthropic.ResponseToolUseBlockType.ToolUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ResponseToolUseBlockTypeJsonConverter))]
        public global::Anthropic.ResponseToolUseBlockType Type { get; set; } = global::Anthropic.ResponseToolUseBlockType.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolUseBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tool_use
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="input"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ResponseToolUseBlock(
            string id,
            string name,
            object input,
            global::Anthropic.ResponseToolUseBlockType type = global::Anthropic.ResponseToolUseBlockType.ToolUse)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolUseBlock" /> class.
        /// </summary>
        public ResponseToolUseBlock()
        {
        }
    }
}