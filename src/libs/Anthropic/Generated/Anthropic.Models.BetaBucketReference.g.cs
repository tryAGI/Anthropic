
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Cloud Storage bucket, named by the project that holds it and by its own name.
    /// </summary>
    public sealed partial class BetaBucketReference
    {
        /// <summary>
        /// The bucket's Cloud Storage name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaBucketReference" /> class.
        /// </summary>
        /// <param name="bucketName">
        /// The bucket's Cloud Storage name.
        /// </param>
        /// <param name="projectNumber">
        /// The number of the Google Cloud project that holds the bucket, in decimal.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBucketReference(
            string bucketName,
            string projectNumber)
        {
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.ProjectNumber = projectNumber ?? throw new global::System.ArgumentNullException(nameof(projectNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBucketReference" /> class.
        /// </summary>
        public BetaBucketReference()
        {
        }

    }
}