
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockStopEvent
    {
        /// <summary>
        /// Default Value: content_block_stop
        /// </summary>
        /// <default>global::Anthropic.ContentBlockStopEventType.ContentBlockStop</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ContentBlockStopEventTypeJsonConverter))]
        public global::Anthropic.ContentBlockStopEventType Type { get; set; } = global::Anthropic.ContentBlockStopEventType.ContentBlockStop;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStopEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_stop
        /// </param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentBlockStopEvent(
            int index,
            global::Anthropic.ContentBlockStopEventType type = global::Anthropic.ContentBlockStopEventType.ContentBlockStop)
        {
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStopEvent" /> class.
        /// </summary>
        public ContentBlockStopEvent()
        {
        }
    }
}