
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Google Cloud Storage bucket.
    /// </summary>
    public sealed partial class BetaGcpExternalStorageConfigParams
    {
        /// <summary>
        /// The bucket's name, without `gs://`: 3 to 63 lower-case letters, digits and hyphens, starting and ending with a letter or digit. It can't start with `goog` or contain `google`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// Project number, not project ID, of the Google Cloud project that holds the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNumber { get; set; }

        /// <summary>
        /// The bucket's Google Cloud region, such as `us-east5`: one of the single regions that the setup guide lists. Dual-regions and multi-regions aren't supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="BetaGcpExternalStorageConfigParams" /> class.
        /// </summary>
        /// <param name="bucketName">
        /// The bucket's name, without `gs://`: 3 to 63 lower-case letters, digits and hyphens, starting and ending with a letter or digit. It can't start with `goog` or contain `google`.
        /// </param>
        /// <param name="projectNumber">
        /// Project number, not project ID, of the Google Cloud project that holds the bucket.
        /// </param>
        /// <param name="region">
        /// The bucket's Google Cloud region, such as `us-east5`: one of the single regions that the setup guide lists. Dual-regions and multi-regions aren't supported.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGcpExternalStorageConfigParams(
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
        /// Initializes a new instance of the <see cref="BetaGcpExternalStorageConfigParams" /> class.
        /// </summary>
        public BetaGcpExternalStorageConfigParams()
        {
        }

    }
}