
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPlugin
    {
        /// <summary>
        /// What the served version contains; null when not enumerated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? Components { get; set; }

        /// <summary>
        /// The served version's content scan; null when it has not been scanned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_scan")]
        public global::Anthropic.BetaPluginContentScan? ContentScan { get; set; }

        /// <summary>
        /// RFC 3339.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Who created the Plugin; null when no creator is recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::Anthropic.CreatedByVariant1? CreatedBy { get; set; }

        /// <summary>
        /// The served version's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The served version's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The Plugin's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The newest version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersionId { get; set; }

        /// <summary>
        /// The version string the served version's manifest declares.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_version")]
        public string? ManifestVersion { get; set; }

        /// <summary>
        /// The ID of the plugin marketplace the Plugin lives in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MarketplaceId { get; set; }

        /// <summary>
        /// Lowercase identifier, unique within its plugin marketplace. Fixed for an organization-owned Plugin's lifetime; a member-owned Plugin's changes when its owner renames it in claude.ai, while its `id` stays the same.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Organization-owned Plugin: the organization-wide installation setting every member gets unless an RBAC Group they belong to holds its own — the Plugin's own setting, or its plugin marketplace's default. Null for a member-owned Plugin, which has shares instead. One of `required`, `auto_install`, `available`, `not_available`; a value this API does not yet name is returned as stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_installation_preference")]
        public global::Anthropic.BetaPluginOrganizationInstallationPreference? OrganizationInstallationPreference { get; set; }

        /// <summary>
        /// Organization-owned Plugin: true while it has no organization-wide setting of its own and `organization_installation_preference` is its plugin marketplace's default. Null for a member-owned Plugin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_installation_preference_inherited")]
        public bool? OrganizationInstallationPreferenceInherited { get; set; }

        /// <summary>
        /// Who owns the Plugin: the organization, or the member whose personal plugin marketplace it lives in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.OwnerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Owner Owner { get; set; }

        /// <summary>
        /// How far the served version reaches: `remote` when it declares an MCP server or a CLI, `privileged` when it declares a hook, monitor, language server or settings but nothing remote, `contained` otherwise; null when not classifiable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reach")]
        public global::Anthropic.BetaPluginReach? Reach { get; set; }

        /// <summary>
        /// The version claude.ai serves to members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("served_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServedVersionId { get; set; }

        /// <summary>
        /// False while the served version follows each new version; true once it has been pinned to one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("served_version_pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ServedVersionPinned { get; set; }

        /// <summary>
        /// Always `plugin`.<br/>
        /// Default Value: plugin
        /// </summary>
        /// <default>"plugin"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin";

        /// <summary>
        /// RFC 3339. Moves on a new version and on a served-version change; a change to the Plugin's installation settings or shares does not move it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPlugin" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339.
        /// </param>
        /// <param name="id">
        /// The Plugin's ID.
        /// </param>
        /// <param name="latestVersionId">
        /// The newest version.
        /// </param>
        /// <param name="marketplaceId">
        /// The ID of the plugin marketplace the Plugin lives in.
        /// </param>
        /// <param name="name">
        /// Lowercase identifier, unique within its plugin marketplace. Fixed for an organization-owned Plugin's lifetime; a member-owned Plugin's changes when its owner renames it in claude.ai, while its `id` stays the same.
        /// </param>
        /// <param name="owner">
        /// Who owns the Plugin: the organization, or the member whose personal plugin marketplace it lives in.
        /// </param>
        /// <param name="servedVersionId">
        /// The version claude.ai serves to members.
        /// </param>
        /// <param name="servedVersionPinned">
        /// False while the served version follows each new version; true once it has been pinned to one.
        /// </param>
        /// <param name="updatedAt">
        /// RFC 3339. Moves on a new version and on a served-version change; a change to the Plugin's installation settings or shares does not move it.
        /// </param>
        /// <param name="components">
        /// What the served version contains; null when not enumerated.
        /// </param>
        /// <param name="contentScan">
        /// The served version's content scan; null when it has not been scanned.
        /// </param>
        /// <param name="createdBy">
        /// Who created the Plugin; null when no creator is recorded.
        /// </param>
        /// <param name="description">
        /// The served version's description.
        /// </param>
        /// <param name="displayName">
        /// The served version's display name.
        /// </param>
        /// <param name="manifestVersion">
        /// The version string the served version's manifest declares.
        /// </param>
        /// <param name="organizationInstallationPreference">
        /// Organization-owned Plugin: the organization-wide installation setting every member gets unless an RBAC Group they belong to holds its own — the Plugin's own setting, or its plugin marketplace's default. Null for a member-owned Plugin, which has shares instead. One of `required`, `auto_install`, `available`, `not_available`; a value this API does not yet name is returned as stored.
        /// </param>
        /// <param name="organizationInstallationPreferenceInherited">
        /// Organization-owned Plugin: true while it has no organization-wide setting of its own and `organization_installation_preference` is its plugin marketplace's default. Null for a member-owned Plugin.
        /// </param>
        /// <param name="reach">
        /// How far the served version reaches: `remote` when it declares an MCP server or a CLI, `privileged` when it declares a hook, monitor, language server or settings but nothing remote, `contained` otherwise; null when not classifiable.
        /// </param>
        /// <param name="type">
        /// Always `plugin`.<br/>
        /// Default Value: plugin
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPlugin(
            global::System.DateTime createdAt,
            string id,
            string latestVersionId,
            string marketplaceId,
            string name,
            global::Anthropic.Owner owner,
            string servedVersionId,
            bool servedVersionPinned,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? components,
            global::Anthropic.BetaPluginContentScan? contentScan,
            global::Anthropic.CreatedByVariant1? createdBy,
            string? description,
            string? displayName,
            string? manifestVersion,
            global::Anthropic.BetaPluginOrganizationInstallationPreference? organizationInstallationPreference,
            bool? organizationInstallationPreferenceInherited,
            global::Anthropic.BetaPluginReach? reach,
            string type = "plugin")
        {
            this.Components = components;
            this.ContentScan = contentScan;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.DisplayName = displayName;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.ManifestVersion = manifestVersion;
            this.MarketplaceId = marketplaceId ?? throw new global::System.ArgumentNullException(nameof(marketplaceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationInstallationPreference = organizationInstallationPreference;
            this.OrganizationInstallationPreferenceInherited = organizationInstallationPreferenceInherited;
            this.Owner = owner;
            this.Reach = reach;
            this.ServedVersionId = servedVersionId ?? throw new global::System.ArgumentNullException(nameof(servedVersionId));
            this.ServedVersionPinned = servedVersionPinned;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPlugin" /> class.
        /// </summary>
        public BetaPlugin()
        {
        }

    }
}