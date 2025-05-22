
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaFileListResponse
    {
        /// <summary>
        /// List of file metadata objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema> Data { get; set; }

        /// <summary>
        /// ID of the first file in this page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// Whether there are more results available.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// ID of the last file in this page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of file metadata objects.
        /// </param>
        /// <param name="firstId">
        /// ID of the first file in this page of results.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results available.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="lastId">
        /// ID of the last file in this page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFileListResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema> data,
            string? firstId,
            bool? hasMore,
            string? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileListResponse" /> class.
        /// </summary>
        public BetaFileListResponse()
        {
        }
    }
}