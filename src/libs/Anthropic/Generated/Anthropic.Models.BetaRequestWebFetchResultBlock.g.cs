
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestWebFetchResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRequestDocumentBlock Content { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the content was retrieved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieved_at")]
        public string? RetrievedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestWebFetchResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaRequestWebFetchResultBlockType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaRequestWebFetchResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="retrievedAt">
        /// ISO 8601 timestamp when the content was retrieved
        /// </param>
        /// <param name="type"></param>
        /// <param name="url">
        /// Fetched content URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestWebFetchResultBlock(
            global::Anthropic.BetaRequestDocumentBlock content,
            string url,
            string? retrievedAt,
            global::Anthropic.BetaRequestWebFetchResultBlockType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RetrievedAt = retrievedAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestWebFetchResultBlock" /> class.
        /// </summary>
        public BetaRequestWebFetchResultBlock()
        {
        }
    }
}