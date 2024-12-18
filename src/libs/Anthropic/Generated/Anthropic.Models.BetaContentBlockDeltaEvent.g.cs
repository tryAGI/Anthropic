
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockDeltaEvent
    {
        /// <summary>
        /// Default Value: content_block_delta
        /// </summary>
        /// <default>global::Anthropic.BetaContentBlockDeltaEventType.ContentBlockDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaContentBlockDeltaEventTypeJsonConverter))]
        public global::Anthropic.BetaContentBlockDeltaEventType Type { get; set; } = global::Anthropic.BetaContentBlockDeltaEventType.ContentBlockDelta;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaTextContentBlockDelta, global::Anthropic.BetaInputJsonContentBlockDelta>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::Anthropic.BetaTextContentBlockDelta, global::Anthropic.BetaInputJsonContentBlockDelta> Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_delta
        /// </param>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaContentBlockDeltaEvent(
            int index,
            global::Anthropic.AnyOf<global::Anthropic.BetaTextContentBlockDelta, global::Anthropic.BetaInputJsonContentBlockDelta> delta,
            global::Anthropic.BetaContentBlockDeltaEventType type = global::Anthropic.BetaContentBlockDeltaEventType.ContentBlockDelta)
        {
            this.Index = index;
            this.Delta = delta;
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