
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAwsExternalKeyConfig
    {
        /// <summary>
        /// Full ARN of the AWS KMS key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KmsArn { get; set; }

        /// <summary>
        /// AWS region. Derived from `kms_arn` if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// IAM role ARN. Deprecated — Anthropic reaches the KMS key via a managed intermediate role; this field is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RoleArn { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaAwsExternalKeyConfig" /> class.
        /// </summary>
        /// <param name="kmsArn">
        /// Full ARN of the AWS KMS key.
        /// </param>
        /// <param name="region">
        /// AWS region. Derived from `kms_arn` if omitted.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAwsExternalKeyConfig(
            string kmsArn,
            string? region,
            string type = "aws")
        {
            this.KmsArn = kmsArn ?? throw new global::System.ArgumentNullException(nameof(kmsArn));
            this.Region = region;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAwsExternalKeyConfig" /> class.
        /// </summary>
        public BetaAwsExternalKeyConfig()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaAwsExternalKeyConfig"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaAwsExternalKeyConfig FromKmsArn(string kmsArn)
        {
            return new BetaAwsExternalKeyConfig
            {
                KmsArn = kmsArn,
            };
        }

    }
}