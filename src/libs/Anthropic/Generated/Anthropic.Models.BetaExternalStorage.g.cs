
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A storage bucket in the organization's own cloud account. Anthropic writes<br/>
    /// inference data to it from each Workspace it is attached to.
    /// </summary>
    public sealed partial class BetaExternalStorage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Human-friendly display name. Null if none was set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The External Storage ID, which starts with `estrg_`. Through Claude Platform on AWS, storage whose `provider_config.type` is `aws` has its bucket ARN as its ID instead: `arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;`, where `&lt;partition&gt;` is the partition of the bucket's region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ProviderConfig3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ProviderConfig3 ProviderConfig { get; set; }

        /// <summary>
        /// The version of Anthropic's setup template whose IAM role names this storage was found to use at activation. Null if no version was recorded, as for storage not yet activated or not on S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup_template_version")]
        public string? SetupTemplateVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Status Status { get; set; }

        /// <summary>
        /// Default Value: external_storage
        /// </summary>
        /// <default>"external_storage"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external_storage";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The user profile the storage is bound to, or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorage" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id">
        /// The External Storage ID, which starts with `estrg_`. Through Claude Platform on AWS, storage whose `provider_config.type` is `aws` has its bucket ARN as its ID instead: `arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;`, where `&lt;partition&gt;` is the partition of the bucket's region.
        /// </param>
        /// <param name="providerConfig"></param>
        /// <param name="status"></param>
        /// <param name="updatedAt"></param>
        /// <param name="displayName">
        /// Human-friendly display name. Null if none was set.
        /// </param>
        /// <param name="setupTemplateVersion">
        /// The version of Anthropic's setup template whose IAM role names this storage was found to use at activation. Null if no version was recorded, as for storage not yet activated or not on S3.
        /// </param>
        /// <param name="userProfileId">
        /// The user profile the storage is bound to, or null.
        /// </param>
        /// <param name="type">
        /// Default Value: external_storage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorage(
            global::System.DateTime createdAt,
            string id,
            global::Anthropic.ProviderConfig3 providerConfig,
            global::Anthropic.Status status,
            global::System.DateTime updatedAt,
            string? displayName,
            string? setupTemplateVersion,
            string? userProfileId,
            string type = "external_storage")
        {
            this.CreatedAt = createdAt;
            this.DisplayName = displayName;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProviderConfig = providerConfig;
            this.SetupTemplateVersion = setupTemplateVersion;
            this.Status = status;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UserProfileId = userProfileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorage" /> class.
        /// </summary>
        public BetaExternalStorage()
        {
        }

    }
}