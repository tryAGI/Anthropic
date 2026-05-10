
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestSearchResultLocationCitation
    {
        /// <summary>
        /// The full text of the cited block range, concatenated.<br/>
        /// Always equals the contents of `content[start_block_index:end_block_index]` joined together. The text block is the minimal citable unit; this field is never a substring of a single block. Not counted toward output tokens, and not counted toward input tokens when sent back in subsequent turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// Exclusive 0-based end index of the cited block range in the source's `content` array.<br/>
        /// Always greater than `start_block_index`; a single-block citation has `end_block_index = start_block_index + 1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndBlockIndex { get; set; }

        /// <summary>
        /// 0-based index of the cited search result among all `search_result` content blocks in the request, in the order they appear across messages and tool results.<br/>
        /// Counted separately from `document_index`; server-side web search results are not included in this count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_result_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SearchResultIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 0-based index of the first cited block in the source's `content` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"search_result_location"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "search_result_location";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSearchResultLocationCitation" /> class.
        /// </summary>
        /// <param name="citedText">
        /// The full text of the cited block range, concatenated.<br/>
        /// Always equals the contents of `content[start_block_index:end_block_index]` joined together. The text block is the minimal citable unit; this field is never a substring of a single block. Not counted toward output tokens, and not counted toward input tokens when sent back in subsequent turns.
        /// </param>
        /// <param name="endBlockIndex">
        /// Exclusive 0-based end index of the cited block range in the source's `content` array.<br/>
        /// Always greater than `start_block_index`; a single-block citation has `end_block_index = start_block_index + 1`.
        /// </param>
        /// <param name="searchResultIndex">
        /// 0-based index of the cited search result among all `search_result` content blocks in the request, in the order they appear across messages and tool results.<br/>
        /// Counted separately from `document_index`; server-side web search results are not included in this count.
        /// </param>
        /// <param name="source"></param>
        /// <param name="startBlockIndex">
        /// 0-based index of the first cited block in the source's `content` array.
        /// </param>
        /// <param name="title"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestSearchResultLocationCitation(
            string citedText,
            int endBlockIndex,
            int searchResultIndex,
            string source,
            int startBlockIndex,
            string? title,
            string type = "search_result_location")
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.EndBlockIndex = endBlockIndex;
            this.SearchResultIndex = searchResultIndex;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.StartBlockIndex = startBlockIndex;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSearchResultLocationCitation" /> class.
        /// </summary>
        public RequestSearchResultLocationCitation()
        {
        }

    }
}