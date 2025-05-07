
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseServerToolUseBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseServerToolUseBlockNameJsonConverter))]
        public global::Anthropic.BetaResponseServerToolUseBlockName Name { get; set; }

        /// <summary>
        /// Default Value: server_tool_use
        /// </summary>
        /// <default>global::Anthropic.BetaResponseServerToolUseBlockType.ServerToolUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseServerToolUseBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseServerToolUseBlockType Type { get; set; } = global::Anthropic.BetaResponseServerToolUseBlockType.ServerToolUse;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseServerToolUseBlock" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: server_tool_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseServerToolUseBlock(
            string id,
            object input,
            global::Anthropic.BetaResponseServerToolUseBlockName name,
            global::Anthropic.BetaResponseServerToolUseBlockType type = global::Anthropic.BetaResponseServerToolUseBlockType.ServerToolUse)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseServerToolUseBlock" /> class.
        /// </summary>
        public BetaResponseServerToolUseBlock()
        {
        }
    }
}