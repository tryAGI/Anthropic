
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseWebFetchResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ResponseDocumentBlock Content { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the content was retrieved<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieved_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RetrievedAt { get; set; }

        /// <summary>
        /// Default Value: web_fetch_result
        /// </summary>
        /// <default>"web_fetch_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "web_fetch_result";

        /// <summary>
        /// Fetched content URL
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
        /// Initializes a new instance of the <see cref="ResponseWebFetchResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="retrievedAt">
        /// ISO 8601 timestamp when the content was retrieved<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: web_fetch_result
        /// </param>
        /// <param name="url">
        /// Fetched content URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseWebFetchResultBlock(
            global::Anthropic.ResponseDocumentBlock content,
            string? retrievedAt,
            string type,
            string url)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.RetrievedAt = retrievedAt ?? throw new global::System.ArgumentNullException(nameof(retrievedAt));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebFetchResultBlock" /> class.
        /// </summary>
        public ResponseWebFetchResultBlock()
        {
        }
    }
}