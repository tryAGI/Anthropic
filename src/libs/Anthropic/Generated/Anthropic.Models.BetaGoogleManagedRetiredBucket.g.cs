
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A bucket that a region has retired. Until `expires_at`, keep the bucket and Anthropic's access to it as they were when the bucket passed verification.
    /// </summary>
    public sealed partial class BetaGoogleManagedRetiredBucket
    {
        /// <summary>
        /// The number of the Google Cloud project that holds the bucket, in decimal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNumber { get; set; }

        /// <summary>
        /// The bucket's Cloud Storage name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// The code of the region that retired the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// When this entry is removed, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedRetiredBucket" /> class.
        /// </summary>
        /// <param name="projectNumber">
        /// The number of the Google Cloud project that holds the bucket, in decimal.
        /// </param>
        /// <param name="bucketName">
        /// The bucket's Cloud Storage name.
        /// </param>
        /// <param name="region">
        /// The code of the region that retired the bucket.
        /// </param>
        /// <param name="expiresAt">
        /// When this entry is removed, in RFC 3339 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedRetiredBucket(
            string projectNumber,
            string bucketName,
            string region,
            global::System.DateTime expiresAt)
        {
            this.ProjectNumber = projectNumber ?? throw new global::System.ArgumentNullException(nameof(projectNumber));
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedRetiredBucket" /> class.
        /// </summary>
        public BetaGoogleManagedRetiredBucket()
        {
        }

    }
}