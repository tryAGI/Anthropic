
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
        /// Opaque cursor for the next page. Supply as `?page=` to fetch the next page; null when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

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
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Supply as `?page=` to fetch the next page; null when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFileListResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileListResponse" /> class.
        /// </summary>
        public BetaFileListResponse()
        {
        }

    }
}