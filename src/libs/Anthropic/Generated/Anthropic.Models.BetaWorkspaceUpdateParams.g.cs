
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
        /// Claude Platform on AWS the value is the AWS KMS key ARN, and the key must be a<br/>
        /// single-Region key in the same AWS account and Region as the Workspace. On that<br/>
        /// platform the key is validated against this Workspace when it is attached, so a<br/>
        /// key-policy problem is reported as an error on this request. This field is write-once:<br/>
        /// once a key is attached to a Workspace it cannot be detached or replaced. To<br/>
        /// rotate key material, rotate the underlying key on your cloud KMS; the<br/>
        /// `external_key_id` stays the same.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_id")]
        public string? ExternalKeyId { get; set; }

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
        /// Claude Platform on AWS the value is the AWS KMS key ARN, and the key must be a<br/>
        /// single-Region key in the same AWS account and Region as the Workspace. On that<br/>
        /// platform the key is validated against this Workspace when it is attached, so a<br/>
        /// key-policy problem is reported as an error on this request. This field is write-once:<br/>
        /// once a key is attached to a Workspace it cannot be detached or replaced. To<br/>
        /// rotate key material, rotate the underlying key on your cloud KMS; the<br/>
        /// `external_key_id` stays the same.
        /// </param>
        /// <param name="name">
        /// Name of the Workspace.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceUpdateParams(
            global::Anthropic.BetaDataResidencyUpdateParams? dataResidency,
            string? displayColor,
            string? externalKeyId,
            string? name,
            object? tags)
        {
            this.DataResidency = dataResidency;
            this.DisplayColor = displayColor;
            this.ExternalKeyId = externalKeyId;
            this.Name = name;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceUpdateParams" /> class.
        /// </summary>
        public BetaWorkspaceUpdateParams()
        {
        }

    }
}