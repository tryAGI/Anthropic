
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseWebSearchResultLocationCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Default Value: web_search_result_location
        /// </summary>
        /// <default>"web_search_result_location"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search_result_location";

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
        /// Initializes a new instance of the <see cref="ResponseWebSearchResultLocationCitation" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="encryptedIndex"></param>
        /// <param name="title"></param>
        /// <param name="type">
        /// Default Value: web_search_result_location
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseWebSearchResultLocationCitation(
            string citedText,
            string encryptedIndex,
            string url,
            string? title,
            string type = "web_search_result_location")
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.EncryptedIndex = encryptedIndex ?? throw new global::System.ArgumentNullException(nameof(encryptedIndex));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchResultLocationCitation" /> class.
        /// </summary>
        public ResponseWebSearchResultLocationCitation()
        {
        }
    }
}