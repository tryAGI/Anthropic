
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseThinkingBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// Default Value: thinking
        /// </summary>
        /// <default>global::Anthropic.ResponseThinkingBlockType.Thinking</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ResponseThinkingBlockTypeJsonConverter))]
        public global::Anthropic.ResponseThinkingBlockType Type { get; set; } = global::Anthropic.ResponseThinkingBlockType.Thinking;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseThinkingBlock" /> class.
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="thinking"></param>
        /// <param name="type">
        /// Default Value: thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseThinkingBlock(
            string signature,
            string thinking,
            global::Anthropic.ResponseThinkingBlockType type = global::Anthropic.ResponseThinkingBlockType.Thinking)
        {
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseThinkingBlock" /> class.
        /// </summary>
        public ResponseThinkingBlock()
        {
        }
    }
}