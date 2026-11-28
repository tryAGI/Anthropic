
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A bucket that a region has retired. Until `expires_at`, keep the bucket and Anthropic's access to it as they were when the bucket passed verification.
    /// </summary>
    public sealed partial class BetaRetiredBucket
    {
        /// <summary>
        /// The bucket's Cloud Storage name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// When this entry is removed, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The number of the Google Cloud project that holds the bucket, in decimal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNumber { get; set; }

        /// <summary>
        /// The code of the region that retired the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRetiredBucket" /> class.
        /// </summary>
        /// <param name="bucketName">
        /// The bucket's Cloud Storage name.
        /// </param>
        /// <param name="expiresAt">
        /// When this entry is removed, in RFC 3339 format.
        /// </param>
        /// <param name="projectNumber">
        /// The number of the Google Cloud project that holds the bucket, in decimal.
        /// </param>
        /// <param name="region">
        /// The code of the region that retired the bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRetiredBucket(
            string bucketName,
            global::System.DateTime expiresAt,
            string projectNumber,
            string region)
        {
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.ExpiresAt = expiresAt;
            this.ProjectNumber = projectNumber ?? throw new global::System.ArgumentNullException(nameof(projectNumber));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRetiredBucket" /> class.
        /// </summary>
        public BetaRetiredBucket()
        {
        }

    }
}