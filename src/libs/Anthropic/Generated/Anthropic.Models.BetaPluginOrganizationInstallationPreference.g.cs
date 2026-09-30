
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginOrganizationInstallationPreference
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
    public static class BetaPluginOrganizationInstallationPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginOrganizationInstallationPreference value)
        {
            return value switch
            {
                BetaPluginOrganizationInstallationPreference.AutoInstall => "auto_install",
                BetaPluginOrganizationInstallationPreference.Available => "available",
                BetaPluginOrganizationInstallationPreference.NotAvailable => "not_available",
                BetaPluginOrganizationInstallationPreference.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginOrganizationInstallationPreference? ToEnum(string value)
        {
            return value switch
            {
                "auto_install" => BetaPluginOrganizationInstallationPreference.AutoInstall,
                "available" => BetaPluginOrganizationInstallationPreference.Available,
                "not_available" => BetaPluginOrganizationInstallationPreference.NotAvailable,
                "required" => BetaPluginOrganizationInstallationPreference.Required,
                _ => null,
            };
        }
    }
}