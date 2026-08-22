
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestRedactedThinkingBlock
    {
        /// <summary>
        /// The `data` value of this redacted thinking block, exactly as returned by the API in a previous response. Opaque and encrypted; pass it back unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="RequestRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="data">
        /// The `data` value of this redacted thinking block, exactly as returned by the API in a previous response. Opaque and encrypted; pass it back unchanged.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestRedactedThinkingBlock(
            string data,
            string type = "redacted_thinking")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestRedactedThinkingBlock" /> class.
        /// </summary>
        public RequestRedactedThinkingBlock()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RequestRedactedThinkingBlock"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RequestRedactedThinkingBlock FromData(string data)
        {
            return new RequestRedactedThinkingBlock
            {
                Data = data,
            };
        }

    }
}