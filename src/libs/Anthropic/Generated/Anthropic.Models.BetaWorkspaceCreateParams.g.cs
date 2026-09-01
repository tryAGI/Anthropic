
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

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
        /// Claude Platform on AWS the value is the AWS KMS key ARN, and the key must be a<br/>
        /// single-Region key in the same AWS account and Region as the Workspace. On that<br/>
        /// platform the key is validated against this Workspace when it is attached, so a<br/>
        /// key-policy problem is reported as an error on this request. This field is write-once:<br/>
        /// once a key is attached to a Workspace it cannot be detached or replaced. To<br/>
        /// rotate key material, rotate the underlying key on your cloud KMS; the<br/>
        /// `external_key_id` stays the same.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceCreateParams(
            string name,
            global::Anthropic.BetaDataResidencyCreateParams? dataResidency,
            string? displayColor,
            string? externalKeyId,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.DataResidency = dataResidency;
            this.DisplayColor = displayColor;
            this.ExternalKeyId = externalKeyId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceCreateParams" /> class.
        /// </summary>
        public BetaWorkspaceCreateParams()
        {
        }

    }
}