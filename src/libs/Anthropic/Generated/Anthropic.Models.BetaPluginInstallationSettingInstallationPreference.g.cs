
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The setting the target holds for this Plugin. One of `required`, `auto_install`, `available`, `not_available`; a value this API does not yet name is returned as stored.
    /// </summary>
    public enum BetaPluginInstallationSettingInstallationPreference
    {
        /// <summary>
        ///
        /// </summary>
        AutoInstall,
        /// <summary>
        ///
        /// </summary>
        Available,
        /// <summary>
        ///
        /// </summary>
        NotAvailable,
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginInstallationSettingInstallationPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginInstallationSettingInstallationPreference value)
        {
            return value switch
            {
                BetaPluginInstallationSettingInstallationPreference.AutoInstall => "auto_install",
                BetaPluginInstallationSettingInstallationPreference.Available => "available",
                BetaPluginInstallationSettingInstallationPreference.NotAvailable => "not_available",
                BetaPluginInstallationSettingInstallationPreference.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginInstallationSettingInstallationPreference? ToEnum(string value)
        {
            return value switch
            {
                "auto_install" => BetaPluginInstallationSettingInstallationPreference.AutoInstall,
                "available" => BetaPluginInstallationSettingInstallationPreference.Available,
                "not_available" => BetaPluginInstallationSettingInstallationPreference.NotAvailable,
                "required" => BetaPluginInstallationSettingInstallationPreference.Required,
                _ => null,
            };
        }
    }
}