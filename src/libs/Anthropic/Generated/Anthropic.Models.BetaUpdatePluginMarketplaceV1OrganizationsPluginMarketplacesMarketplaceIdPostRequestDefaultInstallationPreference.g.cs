
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization-wide installation setting every Plugin in the marketplace without one of its own gets: one of `required`, `auto_install`, `available`, `not_available`. Once set it can be changed but not removed.
    /// </summary>
    public enum BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference
    {
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`. Once set it can be changed but not removed.
        /// </summary>
        AutoInstall,
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`. Once set it can be changed but not removed.
        /// </summary>
        Available,
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`. Once set it can be changed but not removed.
        /// </summary>
        NotAvailable,
        /// <summary>
        /// one of `required`, `auto_install`, `available`, `not_available`. Once set it can be changed but not removed.
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference value)
        {
            return value switch
            {
                BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.AutoInstall => "auto_install",
                BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.Available => "available",
                BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.NotAvailable => "not_available",
                BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference? ToEnum(string value)
        {
            return value switch
            {
                "auto_install" => BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.AutoInstall,
                "available" => BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.Available,
                "not_available" => BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.NotAvailable,
                "required" => BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference.Required,
                _ => null,
            };
        }
    }
}