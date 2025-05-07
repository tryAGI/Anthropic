
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockDeltaEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Delta2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Delta2 Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Default Value: content_block_delta
        /// </summary>
        /// <default>global::Anthropic.ContentBlockDeltaEventType.ContentBlockDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ContentBlockDeltaEventTypeJsonConverter))]
        public global::Anthropic.ContentBlockDeltaEventType Type { get; set; } = global::Anthropic.ContentBlockDeltaEventType.ContentBlockDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="index"></param>
        /// <param name="type">
        /// Default Value: content_block_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentBlockDeltaEvent(
            global::Anthropic.Delta2 delta,
            int index,
            global::Anthropic.ContentBlockDeltaEventType type = global::Anthropic.ContentBlockDeltaEventType.ContentBlockDelta)
        {
            this.Delta = delta;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockDeltaEvent" /> class.
        /// </summary>
        public ContentBlockDeltaEvent()
        {
        }
    }
}