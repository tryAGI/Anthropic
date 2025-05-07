
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkingContentBlockDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// Default Value: thinking_delta
        /// </summary>
        /// <default>global::Anthropic.ThinkingContentBlockDeltaType.ThinkingDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ThinkingContentBlockDeltaTypeJsonConverter))]
        public global::Anthropic.ThinkingContentBlockDeltaType Type { get; set; } = global::Anthropic.ThinkingContentBlockDeltaType.ThinkingDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingContentBlockDelta" /> class.
        /// </summary>
        /// <param name="thinking"></param>
        /// <param name="type">
        /// Default Value: thinking_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingContentBlockDelta(
            string thinking,
            global::Anthropic.ThinkingContentBlockDeltaType type = global::Anthropic.ThinkingContentBlockDeltaType.ThinkingDelta)
        {
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingContentBlockDelta" /> class.
        /// </summary>
        public ThinkingContentBlockDelta()
        {
        }
    }
}