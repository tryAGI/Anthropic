
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkspaceCreateParams
    {
        /// <summary>
        /// Data residency configuration for the workspace. If omitted, defaults to `workspace_geo: "us"`, `allowed_inference_geos: "unrestricted"`, and `default_inference_geo: "global"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_residency")]
        public global::Anthropic.BetaDataResidencyCreateParams? DataResidency { get; set; }

        /// <summary>
        /// Hex color code representing the Workspace in the Anthropic Console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_color")]
        public string? DisplayColor { get; set; }

        /// <summary>
        /// ID of the customer-managed encryption key (CMEK) configuration to use for this<br/>
        /// Workspace. Setting this field requires CMEK to be enabled for your<br/>
        /// organization. When set, data stored for this Workspace is encrypted with the<br/>
        /// referenced key. Create key configurations with the External Keys API. On<br/>
        /// Claude Platform on AWS the value for an AWS KMS key is the key's ARN, and your<br/>
        /// organization's own key must be a single-Region key in the same Region as the<br/>
        /// Workspace. If that key is outside the Workspace's AWS account, it can be attached<br/>
        /// only by updating an active Workspace. On that platform the key is validated<br/>
        /// against this Workspace when it is attached, so a key-policy problem is reported<br/>
        /// as an error on this request. This field is write-once: once a key is attached to<br/>
        /// a Workspace it cannot be detached or replaced. To rotate key material, rotate<br/>
        /// the underlying key on your cloud KMS; the `external_key_id` stays the same.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_id")]
        public string? ExternalKeyId { get; set; }

        /// <summary>
        /// Where the Workspace's retained inference data and transcript copies go, and whether Anthropic's human review applies. Requires the `efs-2026-10-01` `anthropic-beta` value. When omitted, `safeguards_storage` and `transcripts_storage` are `internal` and `human_review` is `enabled`. Cannot be null. An Admin API key can't set this field, because it doesn't belong to a user or a service account. Use an API key that belongs to one, or an OAuth token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_data_privacy")]
        public global::Anthropic.BetaInferenceDataPrivacyCreateParams? InferenceDataPrivacy { get; set; }

        /// <summary>
        /// Name of the Workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// ID of a user profile to attach to the Workspace. Every inference request through the Workspace must then name this user profile; the API rejects a request that names none or a different one. The user profile can't be replaced or removed later; only deleting the user profile clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceCreateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the Workspace.
        /// </param>
        /// <param name="dataResidency">
        /// Data residency configuration for the workspace. If omitted, defaults to `workspace_geo: "us"`, `allowed_inference_geos: "unrestricted"`, and `default_inference_geo: "global"`.
        /// </param>
        /// <param name="displayColor">
        /// Hex color code representing the Workspace in the Anthropic Console.
        /// </param>
        /// <param name="externalKeyId">
        /// ID of the customer-managed encryption key (CMEK) configuration to use for this<br/>
        /// Workspace. Setting this field requires CMEK to be enabled for your<br/>
        /// organization. When set, data stored for this Workspace is encrypted with the<br/>
        /// referenced key. Create key configurations with the External Keys API. On<br/>
        /// Claude Platform on AWS the value for an AWS KMS key is the key's ARN, and your<br/>
        /// organization's own key must be a single-Region key in the same Region as the<br/>
        /// Workspace. If that key is outside the Workspace's AWS account, it can be attached<br/>
        /// only by updating an active Workspace. On that platform the key is validated<br/>
        /// against this Workspace when it is attached, so a key-policy problem is reported<br/>
        /// as an error on this request. This field is write-once: once a key is attached to<br/>
        /// a Workspace it cannot be detached or replaced. To rotate key material, rotate<br/>
        /// the underlying key on your cloud KMS; the `external_key_id` stays the same.
        /// </param>
        /// <param name="inferenceDataPrivacy">
        /// Where the Workspace's retained inference data and transcript copies go, and whether Anthropic's human review applies. Requires the `efs-2026-10-01` `anthropic-beta` value. When omitted, `safeguards_storage` and `transcripts_storage` are `internal` and `human_review` is `enabled`. Cannot be null. An Admin API key can't set this field, because it doesn't belong to a user or a service account. Use an API key that belongs to one, or an OAuth token.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
        /// <param name="userProfileId">
        /// ID of a user profile to attach to the Workspace. Every inference request through the Workspace must then name this user profile; the API rejects a request that names none or a different one. The user profile can't be replaced or removed later; only deleting the user profile clears it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceCreateParams(
            string name,
            global::Anthropic.BetaDataResidencyCreateParams? dataResidency,
            string? displayColor,
            string? externalKeyId,
            global::Anthropic.BetaInferenceDataPrivacyCreateParams? inferenceDataPrivacy,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            string? userProfileId)
        {
            this.DataResidency = dataResidency;
            this.DisplayColor = displayColor;
            this.ExternalKeyId = externalKeyId;
            this.InferenceDataPrivacy = inferenceDataPrivacy;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags;
            this.UserProfileId = userProfileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceCreateParams" /> class.
        /// </summary>
        public BetaWorkspaceCreateParams()
        {
        }

    }
}