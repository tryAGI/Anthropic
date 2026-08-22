
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A file download that finished during this call, reported with the<br/>
    /// same `download_id` as its `download_started` — or without a prior<br/>
    /// `download_started`, when the download finished during the call that<br/>
    /// started it (at most one state change per `download_id` per result).
    /// </summary>
    public sealed partial class BetaBrowserStateChangeDownloadCompleted
    {
        /// <summary>
        /// The caller-assigned identifier for this download, stable across the state changes reporting it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadId { get; set; }

        /// <summary>
        /// Where the executor saved the file, on the executor's filesystem. Only included when another tool in the same environment can read the file at that path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The completed download's size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"download_completed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "download_completed";

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
        /// Initializes a new instance of the <see cref="BetaBrowserStateChangeDownloadCompleted" /> class.
        /// </summary>
        /// <param name="downloadId">
        /// The caller-assigned identifier for this download, stable across the state changes reporting it.
        /// </param>
        /// <param name="url">
        /// The final post-redirect URL the download was served from.
        /// </param>
        /// <param name="path">
        /// Where the executor saved the file, on the executor's filesystem. Only included when another tool in the same environment can read the file at that path.
        /// </param>
        /// <param name="sizeBytes">
        /// The completed download's size.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserStateChangeDownloadCompleted(
            string downloadId,
            string url,
            string? path,
            long? sizeBytes,
            string type = "download_completed")
        {
            this.DownloadId = downloadId ?? throw new global::System.ArgumentNullException(nameof(downloadId));
            this.Path = path;
            this.SizeBytes = sizeBytes;
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserStateChangeDownloadCompleted" /> class.
        /// </summary>
        public BetaBrowserStateChangeDownloadCompleted()
        {
        }

    }
}