
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseWebFetchResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaResponseDocumentBlock Content { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the content was retrieved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieved_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RetrievedAt { get; set; }

        /// <summary>
        /// Default Value: web_fetch_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseWebFetchResultBlockType.WebFetchResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseWebFetchResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseWebFetchResultBlockType Type { get; set; } = global::Anthropic.BetaResponseWebFetchResultBlockType.WebFetchResult;

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
        /// Initializes a new instance of the <see cref="BetaResponseWebFetchResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="retrievedAt">
        /// ISO 8601 timestamp when the content was retrieved
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
        public BetaResponseWebFetchResultBlock(
            global::Anthropic.BetaResponseDocumentBlock content,
            string? retrievedAt,
            string url,
            global::Anthropic.BetaResponseWebFetchResultBlockType type = global::Anthropic.BetaResponseWebFetchResultBlockType.WebFetchResult)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.RetrievedAt = retrievedAt ?? throw new global::System.ArgumentNullException(nameof(retrievedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebFetchResultBlock" /> class.
        /// </summary>
        public BetaResponseWebFetchResultBlock()
        {
        }
    }
}