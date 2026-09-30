
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The installation setting the target is to hold for this Plugin: one of `required`, `auto_install`, `available`, `not_available`.
    /// </summary>
    public enum BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference
    {
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`.
        /// </summary>
        AutoInstall,
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`.
        /// </summary>
        Available,
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`.
        /// </summary>
        NotAvailable,
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`.
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference value)
        {
            return value switch
            {
                BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.AutoInstall => "auto_install",
                BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.Available => "available",
                BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.NotAvailable => "not_available",
                BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference? ToEnum(string value)
        {
            return value switch
            {
                "auto_install" => BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.AutoInstall,
                "available" => BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.Available,
                "not_available" => BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.NotAvailable,
                "required" => BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference.Required,
                _ => null,
            };
        }
    }
}