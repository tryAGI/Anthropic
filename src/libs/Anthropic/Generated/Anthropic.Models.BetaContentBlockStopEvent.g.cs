
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockStopEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Default Value: content_block_stop
        /// </summary>
        /// <default>global::Anthropic.BetaContentBlockStopEventType.ContentBlockStop</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaContentBlockStopEventTypeJsonConverter))]
        public global::Anthropic.BetaContentBlockStopEventType Type { get; set; } = global::Anthropic.BetaContentBlockStopEventType.ContentBlockStop;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStopEvent" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type">
        /// Default Value: content_block_stop
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContentBlockStopEvent(
            int index,
            global::Anthropic.BetaContentBlockStopEventType type = global::Anthropic.BetaContentBlockStopEventType.ContentBlockStop)
        {
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStopEvent" /> class.
        /// </summary>
        public BetaContentBlockStopEvent()
        {
        }
    }
}