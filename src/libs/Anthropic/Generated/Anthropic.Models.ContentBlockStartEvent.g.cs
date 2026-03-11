
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockStartEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_block")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ContentBlock2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Anthropic.ContentBlock2 ContentBlock { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Default Value: content_block_start
        /// </summary>
        /// <default>"content_block_start"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "content_block_start";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStartEvent" /> class.
        /// </summary>
        /// <param name="contentBlock"></param>
        /// <param name="index"></param>
        /// <param name="type">
        /// Default Value: content_block_start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentBlockStartEvent(
            global::Anthropic.ContentBlock2 contentBlock,
            int index,
            string type = "content_block_start")
        {
            this.ContentBlock = contentBlock;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStartEvent" /> class.
        /// </summary>
        public ContentBlockStartEvent()
        {
        }
    }
}