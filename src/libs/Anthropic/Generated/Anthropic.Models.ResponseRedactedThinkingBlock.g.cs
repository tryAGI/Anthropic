
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseRedactedThinkingBlock
    {
        /// <summary>
        /// The contents of this redacted thinking block, returned when portions of the model's thinking were safety-redacted. This field is opaque and encrypted, with no readable content.<br/>
        /// Pass `redacted_thinking` blocks back to the API unchanged when continuing a multi-turn conversation.<br/>
        /// See [extended thinking](https://platform.claude.com/docs/en/build-with-claude/extended-thinking#redacted-thinking-blocks) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Default Value: redacted_thinking
        /// </summary>
        /// <default>"redacted_thinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "redacted_thinking";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="data">
        /// The contents of this redacted thinking block, returned when portions of the model's thinking were safety-redacted. This field is opaque and encrypted, with no readable content.<br/>
        /// Pass `redacted_thinking` blocks back to the API unchanged when continuing a multi-turn conversation.<br/>
        /// See [extended thinking](https://platform.claude.com/docs/en/build-with-claude/extended-thinking#redacted-thinking-blocks) for details.
        /// </param>
        /// <param name="type">
        /// Default Value: redacted_thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseRedactedThinkingBlock(
            string data,
            string type = "redacted_thinking")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRedactedThinkingBlock" /> class.
        /// </summary>
        public ResponseRedactedThinkingBlock()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseRedactedThinkingBlock"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseRedactedThinkingBlock FromData(string data)
        {
            return new ResponseRedactedThinkingBlock
            {
                Data = data,
            };
        }

    }
}