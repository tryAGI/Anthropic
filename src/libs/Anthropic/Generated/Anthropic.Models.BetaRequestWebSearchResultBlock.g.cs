
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestWebSearchResultBlock
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
        public string? PageAge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"web_search_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search_result";

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
        /// Initializes a new instance of the <see cref="BetaRequestWebSearchResultBlock" /> class.
        /// </summary>
        /// <param name="encryptedContent"></param>
        /// <param name="title"></param>
        /// <param name="url"></param>
        /// <param name="pageAge"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestWebSearchResultBlock(
            string encryptedContent,
            string title,
            string url,
            string? pageAge,
            string type = "web_search_result")
        {
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
            this.PageAge = pageAge;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestWebSearchResultBlock" /> class.
        /// </summary>
        public BetaRequestWebSearchResultBlock()
        {
        }
    }
}