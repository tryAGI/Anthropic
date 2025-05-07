
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockDeltaEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.DeltaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Delta Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Default Value: content_block_delta
        /// </summary>
        /// <default>global::Anthropic.BetaContentBlockDeltaEventType.ContentBlockDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaContentBlockDeltaEventTypeJsonConverter))]
        public global::Anthropic.BetaContentBlockDeltaEventType Type { get; set; } = global::Anthropic.BetaContentBlockDeltaEventType.ContentBlockDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="index"></param>
        /// <param name="type">
        /// Default Value: content_block_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContentBlockDeltaEvent(
            global::Anthropic.Delta delta,
            int index,
            global::Anthropic.BetaContentBlockDeltaEventType type = global::Anthropic.BetaContentBlockDeltaEventType.ContentBlockDelta)
        {
            this.Delta = delta;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockDeltaEvent" /> class.
        /// </summary>
        public BetaContentBlockDeltaEvent()
        {
        }
    }
}