
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A file download that failed — or was cancelled — during this call.
    /// </summary>
    public sealed partial class BetaBrowserStateChangeDownloadFailed
    {
        /// <summary>
        /// The caller-assigned identifier for this download, stable across the state changes reporting it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadId { get; set; }

        /// <summary>
        /// The failure or cancellation detail, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"download_failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "download_failed";

        /// <summary>
        /// The final post-redirect URL the download was served from.
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
        /// Initializes a new instance of the <see cref="BetaBrowserStateChangeDownloadFailed" /> class.
        /// </summary>
        /// <param name="downloadId">
        /// The caller-assigned identifier for this download, stable across the state changes reporting it.
        /// </param>
        /// <param name="url">
        /// The final post-redirect URL the download was served from.
        /// </param>
        /// <param name="error">
        /// The failure or cancellation detail, when known.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserStateChangeDownloadFailed(
            string downloadId,
            string url,
            string? error,
            string type = "download_failed")
        {
            this.DownloadId = downloadId ?? throw new global::System.ArgumentNullException(nameof(downloadId));
            this.Error = error;
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserStateChangeDownloadFailed" /> class.
        /// </summary>
        public BetaBrowserStateChangeDownloadFailed()
        {
        }

    }
}