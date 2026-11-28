
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An Amazon S3 bucket.
    /// </summary>
    public sealed partial class BetaAwsExternalStorageConfig
    {
        /// <summary>
        /// 12-digit ID of the AWS account that owns the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// The bucket's name, without `s3://`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// The bucket's AWS region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Default Value: aws
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
        /// Initializes a new instance of the <see cref="BetaAwsExternalStorageConfig" /> class.
        /// </summary>
        /// <param name="accountId">
        /// 12-digit ID of the AWS account that owns the bucket.
        /// </param>
        /// <param name="bucketName">
        /// The bucket's name, without `s3://`.
        /// </param>
        /// <param name="region">
        /// The bucket's AWS region.
        /// </param>
        /// <param name="type">
        /// Default Value: aws
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAwsExternalStorageConfig(
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
        /// Initializes a new instance of the <see cref="BetaAwsExternalStorageConfig" /> class.
        /// </summary>
        public BetaAwsExternalStorageConfig()
        {
        }

    }
}