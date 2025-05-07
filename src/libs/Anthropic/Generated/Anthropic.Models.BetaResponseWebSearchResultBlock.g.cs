
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseWebSearchResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_age")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PageAge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Default Value: web_search_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseWebSearchResultBlockType.WebSearchResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseWebSearchResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseWebSearchResultBlockType Type { get; set; } = global::Anthropic.BetaResponseWebSearchResultBlockType.WebSearchResult;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebSearchResultBlock" /> class.
        /// </summary>
        /// <param name="encryptedContent"></param>
        /// <param name="pageAge"></param>
        /// <param name="title"></param>
        /// <param name="type">
        /// Default Value: web_search_result
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseWebSearchResultBlock(
            string encryptedContent,
            string? pageAge,
            string title,
            string url,
            global::Anthropic.BetaResponseWebSearchResultBlockType type = global::Anthropic.BetaResponseWebSearchResultBlockType.WebSearchResult)
        {
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
            this.PageAge = pageAge ?? throw new global::System.ArgumentNullException(nameof(pageAge));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebSearchResultBlock" /> class.
        /// </summary>
        public BetaResponseWebSearchResultBlock()
        {
        }
    }
}