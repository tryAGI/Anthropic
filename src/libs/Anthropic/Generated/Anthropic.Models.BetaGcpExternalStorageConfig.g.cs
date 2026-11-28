
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Google Cloud Storage bucket.
    /// </summary>
    public sealed partial class BetaGcpExternalStorageConfig
    {
        /// <summary>
        /// The bucket's name, without `gs://`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// Number of the Google Cloud project that holds the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNumber { get; set; }

        /// <summary>
        /// The bucket's Google Cloud region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Default Value: gcp
        /// </summary>
        /// <default>"gcp"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "gcp";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGcpExternalStorageConfig" /> class.
        /// </summary>
        /// <param name="bucketName">
        /// The bucket's name, without `gs://`.
        /// </param>
        /// <param name="projectNumber">
        /// Number of the Google Cloud project that holds the bucket.
        /// </param>
        /// <param name="region">
        /// The bucket's Google Cloud region.
        /// </param>
        /// <param name="type">
        /// Default Value: gcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGcpExternalStorageConfig(
            string bucketName,
            string projectNumber,
            string region,
            string type = "gcp")
        {
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.ProjectNumber = projectNumber ?? throw new global::System.ArgumentNullException(nameof(projectNumber));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGcpExternalStorageConfig" /> class.
        /// </summary>
        public BetaGcpExternalStorageConfig()
        {
        }

    }
}