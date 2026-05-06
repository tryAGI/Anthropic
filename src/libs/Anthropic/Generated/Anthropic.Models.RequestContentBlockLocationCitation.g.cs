
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestContentBlockLocationCitation
    {
        /// <summary>
        /// The full text of the cited block range, concatenated.<br/>
        /// Always equals the contents of `content[start_block_index:end_block_index]` joined together. The text block is the minimal citable unit; this field is never a substring of a single block. Not counted toward output tokens, and not counted toward input tokens when sent back in subsequent turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// Exclusive 0-based end index of the cited block range in the source's `content` array.<br/>
        /// Always greater than `start_block_index`; a single-block citation has `end_block_index = start_block_index + 1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndBlockIndex { get; set; }

        /// <summary>
        /// 0-based index of the first cited block in the source's `content` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"content_block_location"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "content_block_location";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContentBlockLocationCitation" /> class.
        /// </summary>
        /// <param name="citedText">
        /// The full text of the cited block range, concatenated.<br/>
        /// Always equals the contents of `content[start_block_index:end_block_index]` joined together. The text block is the minimal citable unit; this field is never a substring of a single block. Not counted toward output tokens, and not counted toward input tokens when sent back in subsequent turns.
        /// </param>
        /// <param name="documentIndex"></param>
        /// <param name="endBlockIndex">
        /// Exclusive 0-based end index of the cited block range in the source's `content` array.<br/>
        /// Always greater than `start_block_index`; a single-block citation has `end_block_index = start_block_index + 1`.
        /// </param>
        /// <param name="startBlockIndex">
        /// 0-based index of the first cited block in the source's `content` array.
        /// </param>
        /// <param name="documentTitle"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestContentBlockLocationCitation(
            string citedText,
            int documentIndex,
            int endBlockIndex,
            int startBlockIndex,
            string? documentTitle,
            string type = "content_block_location")
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.EndBlockIndex = endBlockIndex;
            this.StartBlockIndex = startBlockIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContentBlockLocationCitation" /> class.
        /// </summary>
        public RequestContentBlockLocationCitation()
        {
        }
    }
}