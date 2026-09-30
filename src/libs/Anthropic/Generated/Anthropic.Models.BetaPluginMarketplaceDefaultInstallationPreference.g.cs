
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginMarketplaceDefaultInstallationPreference
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
    public static class BetaPluginMarketplaceDefaultInstallationPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginMarketplaceDefaultInstallationPreference value)
        {
            return value switch
            {
                BetaPluginMarketplaceDefaultInstallationPreference.AutoInstall => "auto_install",
                BetaPluginMarketplaceDefaultInstallationPreference.Available => "available",
                BetaPluginMarketplaceDefaultInstallationPreference.NotAvailable => "not_available",
                BetaPluginMarketplaceDefaultInstallationPreference.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginMarketplaceDefaultInstallationPreference? ToEnum(string value)
        {
            return value switch
            {
                "auto_install" => BetaPluginMarketplaceDefaultInstallationPreference.AutoInstall,
                "available" => BetaPluginMarketplaceDefaultInstallationPreference.Available,
                "not_available" => BetaPluginMarketplaceDefaultInstallationPreference.NotAvailable,
                "required" => BetaPluginMarketplaceDefaultInstallationPreference.Required,
                _ => null,
            };
        }
    }
}