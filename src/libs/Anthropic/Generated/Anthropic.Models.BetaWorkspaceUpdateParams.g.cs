
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Partial update — omitted fields are unchanged.
    /// </summary>
    public sealed partial class BetaWorkspaceUpdateParams
    {
        /// <summary>
        /// Data residency configuration for the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_residency")]
        public global::Anthropic.BetaDataResidencyUpdateParams? DataResidency { get; set; }

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
        /// Changes to where the Workspace's retained inference data and transcript copies go, and to whether Anthropic's human review applies. Requires the `efs-2026-10-01` `anthropic-beta` value. An omitted member is unchanged. Cannot be null. An Admin API key can't set this field, because it doesn't belong to a user or a service account. Use an API key that belongs to one, or an OAuth token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_data_privacy")]
        public global::Anthropic.BetaInferenceDataPrivacyUpdateParams? InferenceDataPrivacy { get; set; }

        /// <summary>
        /// Name of the Workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// ID of a user profile to attach to the Workspace. Every inference request through the Workspace must then name this user profile; the API rejects a request that names none or a different one. Once set, it can't be replaced or removed (sending the same ID again changes nothing); only deleting the user profile clears it. It can't be set on a Workspace whose External Key isn't bound to this user profile. The default Workspace can't have a user profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceUpdateParams" /> class.
        /// </summary>
        /// <param name="dataResidency">
        /// Data residency configuration for the workspace.
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
        /// Changes to where the Workspace's retained inference data and transcript copies go, and to whether Anthropic's human review applies. Requires the `efs-2026-10-01` `anthropic-beta` value. An omitted member is unchanged. Cannot be null. An Admin API key can't set this field, because it doesn't belong to a user or a service account. Use an API key that belongs to one, or an OAuth token.
        /// </param>
        /// <param name="name">
        /// Name of the Workspace.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
        /// <param name="userProfileId">
        /// ID of a user profile to attach to the Workspace. Every inference request through the Workspace must then name this user profile; the API rejects a request that names none or a different one. Once set, it can't be replaced or removed (sending the same ID again changes nothing); only deleting the user profile clears it. It can't be set on a Workspace whose External Key isn't bound to this user profile. The default Workspace can't have a user profile.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceUpdateParams(
            global::Anthropic.BetaDataResidencyUpdateParams? dataResidency,
            string? displayColor,
            string? externalKeyId,
            global::Anthropic.BetaInferenceDataPrivacyUpdateParams? inferenceDataPrivacy,
            string? name,
            object? tags,
            string? userProfileId)
        {
            this.DataResidency = dataResidency;
            this.DisplayColor = displayColor;
            this.ExternalKeyId = externalKeyId;
            this.InferenceDataPrivacy = inferenceDataPrivacy;
            this.Name = name;
            this.Tags = tags;
            this.UserProfileId = userProfileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceUpdateParams" /> class.
        /// </summary>
        public BetaWorkspaceUpdateParams()
        {
        }

    }
}