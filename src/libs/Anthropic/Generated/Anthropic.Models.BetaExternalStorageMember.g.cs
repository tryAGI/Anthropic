
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization's External Storage that `external_storage_id` names.
    /// </summary>
    public sealed partial class BetaExternalStorageMember
    {
        /// <summary>
        /// The External Storage ID, which starts with `estrg_`. Through Claude Platform on AWS, storage whose `provider_config.type` is `aws` has its bucket ARN as its ID instead: `arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;`, where `&lt;partition&gt;` is the partition of the bucket's region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_storage_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalStorageId { get; set; }

        /// <summary>
        /// Default Value: external
        /// </summary>
        /// <default>"external"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageMember" /> class.
        /// </summary>
        /// <param name="externalStorageId">
        /// The External Storage ID, which starts with `estrg_`. Through Claude Platform on AWS, storage whose `provider_config.type` is `aws` has its bucket ARN as its ID instead: `arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;`, where `&lt;partition&gt;` is the partition of the bucket's region.
        /// </param>
        /// <param name="type">
        /// Default Value: external
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorageMember(
            string externalStorageId,
            string type = "external")
        {
            this.ExternalStorageId = externalStorageId ?? throw new global::System.ArgumentNullException(nameof(externalStorageId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageMember" /> class.
        /// </summary>
        public BetaExternalStorageMember()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaExternalStorageMember"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaExternalStorageMember FromExternalStorageId(string externalStorageId)
        {
            return new BetaExternalStorageMember
            {
                ExternalStorageId = externalStorageId,
            };
        }

    }
}