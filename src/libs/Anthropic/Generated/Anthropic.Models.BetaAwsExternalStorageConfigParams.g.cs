
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An Amazon S3 bucket.
    /// </summary>
    public sealed partial class BetaAwsExternalStorageConfigParams
    {
        /// <summary>
        /// 12-digit ID of the AWS account that owns the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// The bucket's name, without `s3://`: 3 to 63 lower-case letters, digits and hyphens, starting and ending with a letter or digit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// The bucket's AWS region. Activating the storage fails if Anthropic can't use buckets in that region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"aws"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "aws";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAwsExternalStorageConfigParams" /> class.
        /// </summary>
        /// <param name="accountId">
        /// 12-digit ID of the AWS account that owns the bucket.
        /// </param>
        /// <param name="bucketName">
        /// The bucket's name, without `s3://`: 3 to 63 lower-case letters, digits and hyphens, starting and ending with a letter or digit.
        /// </param>
        /// <param name="region">
        /// The bucket's AWS region. Activating the storage fails if Anthropic can't use buckets in that region.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAwsExternalStorageConfigParams(
            string accountId,
            string bucketName,
            string region,
            string type = "aws")
        {
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAwsExternalStorageConfigParams" /> class.
        /// </summary>
        public BetaAwsExternalStorageConfigParams()
        {
        }

    }
}