
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The installation setting an organization-owned Plugin holds for one<br/>
    /// target. It has no ID of its own: it is addressed by the Plugin's ID and the<br/>
    /// target.
    /// </summary>
    public sealed partial class BetaPluginInstallationSetting
    {
        /// <summary>
        /// When the target was first given a setting for this Plugin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The setting the target holds for this Plugin. One of `required`, `auto_install`, `available`, `not_available`; a value this API does not yet name is returned as stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaPluginInstallationSettingInstallationPreferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaPluginInstallationSettingInstallationPreference InstallationPreference { get; set; }

        /// <summary>
        /// The Plugin's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginId { get; set; }

        /// <summary>
        /// Whose setting this is: `organization` (the Plugin's own organization-wide setting) or `rbac_group` (one RBAC Group's own setting); `organization_member` does not occur here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.TargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Target Target { get; set; }

        /// <summary>
        /// Always `plugin_installation_setting`.<br/>
        /// Default Value: plugin_installation_setting
        /// </summary>
        /// <default>"plugin_installation_setting"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin_installation_setting";

        /// <summary>
        /// When its setting last changed.
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
        /// Initializes a new instance of the <see cref="BetaPluginInstallationSetting" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When the target was first given a setting for this Plugin.
        /// </param>
        /// <param name="installationPreference">
        /// The setting the target holds for this Plugin. One of `required`, `auto_install`, `available`, `not_available`; a value this API does not yet name is returned as stored.
        /// </param>
        /// <param name="pluginId">
        /// The Plugin's ID.
        /// </param>
        /// <param name="target">
        /// Whose setting this is: `organization` (the Plugin's own organization-wide setting) or `rbac_group` (one RBAC Group's own setting); `organization_member` does not occur here.
        /// </param>
        /// <param name="updatedAt">
        /// When its setting last changed.
        /// </param>
        /// <param name="type">
        /// Always `plugin_installation_setting`.<br/>
        /// Default Value: plugin_installation_setting
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginInstallationSetting(
            global::System.DateTime createdAt,
            global::Anthropic.BetaPluginInstallationSettingInstallationPreference installationPreference,
            string pluginId,
            global::Anthropic.Target target,
            global::System.DateTime updatedAt,
            string type = "plugin_installation_setting")
        {
            this.CreatedAt = createdAt;
            this.InstallationPreference = installationPreference;
            this.PluginId = pluginId ?? throw new global::System.ArgumentNullException(nameof(pluginId));
            this.Target = target;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginInstallationSetting" /> class.
        /// </summary>
        public BetaPluginInstallationSetting()
        {
        }

    }
}