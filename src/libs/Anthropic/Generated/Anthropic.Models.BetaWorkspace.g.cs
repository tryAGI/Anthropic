
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkspace
    {
        /// <summary>
        /// RFC 3339 datetime string indicating when the Workspace was archived, or `null` if the Workspace is not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Identifier for this Workspace's encryption compartment. When you configure a<br/>
        /// customer-managed encryption key (CMEK) on AWS, reference this value in your<br/>
        /// KMS key-policy condition so the key is scoped to this compartment. On GCP and<br/>
        /// Azure, Anthropic enforces the compartment binding automatically; you do not<br/>
        /// need to reference this value in your key configuration. See the CMEK integration guide for the<br/>
        /// required key configuration, including the value used during key validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compartment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompartmentId { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the Workspace was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Data residency configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_residency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDataResidency DataResidency { get; set; }

        /// <summary>
        /// Hex color code representing the Workspace in the Anthropic Console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayColor { get; set; }

        /// <summary>
        /// ID of the customer-managed encryption key (CMEK) configuration to use for this<br/>
        /// Workspace. Setting this field requires CMEK to be enabled for your<br/>
        /// organization. When set, data stored for this Workspace is encrypted with the<br/>
        /// referenced key. Create key configurations with the External Keys API. This<br/>
        /// field is write-once: once a key is attached to a Workspace it cannot be<br/>
        /// detached or replaced. To rotate key material, rotate the underlying key on<br/>
        /// your cloud KMS; the `external_key_id` stays the same.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_id")]
        public string? ExternalKeyId { get; set; }

        /// <summary>
        /// ID of the Workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Workspaces, this is always `"workspace"`.<br/>
        /// Default Value: workspace
        /// </summary>
        /// <default>"workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workspace";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspace" /> class.
        /// </summary>
        /// <param name="compartmentId">
        /// Identifier for this Workspace's encryption compartment. When you configure a<br/>
        /// customer-managed encryption key (CMEK) on AWS, reference this value in your<br/>
        /// KMS key-policy condition so the key is scoped to this compartment. On GCP and<br/>
        /// Azure, Anthropic enforces the compartment binding automatically; you do not<br/>
        /// need to reference this value in your key configuration. See the CMEK integration guide for the<br/>
        /// required key configuration, including the value used during key validation.
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 datetime string indicating when the Workspace was created.
        /// </param>
        /// <param name="dataResidency">
        /// Data residency configuration.
        /// </param>
        /// <param name="displayColor">
        /// Hex color code representing the Workspace in the Anthropic Console.
        /// </param>
        /// <param name="id">
        /// ID of the Workspace.
        /// </param>
        /// <param name="name">
        /// Name of the Workspace.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 datetime string indicating when the Workspace was archived, or `null` if the Workspace is not archived.
        /// </param>
        /// <param name="externalKeyId">
        /// ID of the customer-managed encryption key (CMEK) configuration to use for this<br/>
        /// Workspace. Setting this field requires CMEK to be enabled for your<br/>
        /// organization. When set, data stored for this Workspace is encrypted with the<br/>
        /// referenced key. Create key configurations with the External Keys API. This<br/>
        /// field is write-once: once a key is attached to a Workspace it cannot be<br/>
        /// detached or replaced. To rotate key material, rotate the underlying key on<br/>
        /// your cloud KMS; the `external_key_id` stays the same.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Workspaces, this is always `"workspace"`.<br/>
        /// Default Value: workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspace(
            string compartmentId,
            global::System.DateTime createdAt,
            global::Anthropic.BetaDataResidency dataResidency,
            string displayColor,
            string id,
            string name,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            global::System.DateTime? archivedAt,
            string? externalKeyId,
            string type = "workspace")
        {
            this.ArchivedAt = archivedAt;
            this.CompartmentId = compartmentId ?? throw new global::System.ArgumentNullException(nameof(compartmentId));
            this.CreatedAt = createdAt;
            this.DataResidency = dataResidency ?? throw new global::System.ArgumentNullException(nameof(dataResidency));
            this.DisplayColor = displayColor ?? throw new global::System.ArgumentNullException(nameof(displayColor));
            this.ExternalKeyId = externalKeyId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspace" /> class.
        /// </summary>
        public BetaWorkspace()
        {
        }

    }
}