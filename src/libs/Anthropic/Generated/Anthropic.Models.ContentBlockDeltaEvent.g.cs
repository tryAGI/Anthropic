
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockDeltaEvent
    {
        /// <summary>
        /// Default Value: content_block_delta
        /// </summary>
        /// <default>global::Anthropic.ContentBlockDeltaEventType.ContentBlockDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ContentBlockDeltaEventTypeJsonConverter))]
        public global::Anthropic.ContentBlockDeltaEventType Type { get; set; } = global::Anthropic.ContentBlockDeltaEventType.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Delta2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Delta2 Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_delta
        /// </param>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ContentBlockDeltaEvent(
            int index,
            global::Anthropic.Delta2 delta,
            global::Anthropic.ContentBlockDeltaEventType type = global::Anthropic.ContentBlockDeltaEventType.ContentBlockDelta)
        {
            this.Index = index;
            this.Delta = delta;
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