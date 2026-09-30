
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The installation setting one target is to hold for the Plugin: one of<br/>
    /// the four values. `null` and any other field are refused.
    /// </summary>
    public sealed partial class BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest
    {
        /// <summary>
        /// The installation setting the target is to hold for this Plugin: one of `required`, `auto_install`, `available`, `not_available`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference InstallationPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest" /> class.
        /// </summary>
        /// <param name="installationPreference">
        /// The installation setting the target is to hold for this Plugin: one of `required`, `auto_install`, `available`, `not_available`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest(
            global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference installationPreference)
        {
            this.InstallationPreference = installationPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest" /> class.
        /// </summary>
        public BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest()
        {
        }

    }
}