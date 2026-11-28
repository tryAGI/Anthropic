
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The bucket configured for a region.
    /// </summary>
    public sealed partial class BetaStorageBucket
    {
        /// <summary>
        /// The bucket's Cloud Storage name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// The resource name of the Cloud KMS key that the bucket encrypts objects under by default. `null` until the region has confirmed the bucket, and when the bucket has no default key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_name")]
        public string? KmsKeyName { get; set; }

        /// <summary>
        /// The bucket's location, as Cloud Storage reports it. `null` until the region has confirmed the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The ID of the project that holds the bucket. `null` until the region has confirmed the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The number of the Google Cloud project that holds the bucket, in decimal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageBucket" /> class.
        /// </summary>
        /// <param name="bucketName">
        /// The bucket's Cloud Storage name.
        /// </param>
        /// <param name="projectNumber">
        /// The number of the Google Cloud project that holds the bucket, in decimal.
        /// </param>
        /// <param name="kmsKeyName">
        /// The resource name of the Cloud KMS key that the bucket encrypts objects under by default. `null` until the region has confirmed the bucket, and when the bucket has no default key.
        /// </param>
        /// <param name="location">
        /// The bucket's location, as Cloud Storage reports it. `null` until the region has confirmed the bucket.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project that holds the bucket. `null` until the region has confirmed the bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageBucket(
            string bucketName,
            string projectNumber,
            string? kmsKeyName,
            string? location,
            string? projectId)
        {
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.KmsKeyName = kmsKeyName;
            this.Location = location;
            this.ProjectId = projectId;
            this.ProjectNumber = projectNumber ?? throw new global::System.ArgumentNullException(nameof(projectNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageBucket" /> class.
        /// </summary>
        public BetaStorageBucket()
        {
        }

    }
}