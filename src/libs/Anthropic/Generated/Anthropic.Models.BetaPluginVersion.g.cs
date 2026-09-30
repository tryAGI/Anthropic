
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginVersion
    {
        /// <summary>
        /// What the version contains; null when not enumerated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? Components { get; set; }

        /// <summary>
        /// This version's content scan; null when it has not been scanned.
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
        /// Who uploaded this version; null when not recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::Anthropic.CreatedByVariant12? CreatedBy { get; set; }

        /// <summary>
        /// The manifest's description; null when it declares none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The manifest's display name; null when it declares none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The version's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The version string the manifest declares; null when it declares none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_version")]
        public string? ManifestVersion { get; set; }

        /// <summary>
        /// The Plugin's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginId { get; set; }

        /// <summary>
        /// How far the version reaches: `remote`, `privileged` or `contained`, as on the Plugin; null when not classifiable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reach")]
        public global::Anthropic.BetaPluginVersionReach? Reach { get; set; }

        /// <summary>
        /// As supplied with the upload; null when none were supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_notes")]
        public string? ReleaseNotes { get; set; }

        /// <summary>
        /// Always `plugin_version`.<br/>
        /// Default Value: plugin_version
        /// </summary>
        /// <default>"plugin_version"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin_version";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginVersion" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339.
        /// </param>
        /// <param name="id">
        /// The version's ID.
        /// </param>
        /// <param name="pluginId">
        /// The Plugin's ID.
        /// </param>
        /// <param name="components">
        /// What the version contains; null when not enumerated.
        /// </param>
        /// <param name="contentScan">
        /// This version's content scan; null when it has not been scanned.
        /// </param>
        /// <param name="createdBy">
        /// Who uploaded this version; null when not recorded.
        /// </param>
        /// <param name="description">
        /// The manifest's description; null when it declares none.
        /// </param>
        /// <param name="displayName">
        /// The manifest's display name; null when it declares none.
        /// </param>
        /// <param name="manifestVersion">
        /// The version string the manifest declares; null when it declares none.
        /// </param>
        /// <param name="reach">
        /// How far the version reaches: `remote`, `privileged` or `contained`, as on the Plugin; null when not classifiable.
        /// </param>
        /// <param name="releaseNotes">
        /// As supplied with the upload; null when none were supplied.
        /// </param>
        /// <param name="type">
        /// Always `plugin_version`.<br/>
        /// Default Value: plugin_version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginVersion(
            global::System.DateTime createdAt,
            string id,
            string pluginId,
            global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? components,
            global::Anthropic.BetaPluginContentScan? contentScan,
            global::Anthropic.CreatedByVariant12? createdBy,
            string? description,
            string? displayName,
            string? manifestVersion,
            global::Anthropic.BetaPluginVersionReach? reach,
            string? releaseNotes,
            string type = "plugin_version")
        {
            this.Components = components;
            this.ContentScan = contentScan;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.DisplayName = displayName;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ManifestVersion = manifestVersion;
            this.PluginId = pluginId ?? throw new global::System.ArgumentNullException(nameof(pluginId));
            this.Reach = reach;
            this.ReleaseNotes = releaseNotes;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginVersion" /> class.
        /// </summary>
        public BetaPluginVersion()
        {
        }

    }
}