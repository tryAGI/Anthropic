
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType value)
        {
            return value switch
            {
                BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType.Organization => "organization",
                BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType.Organization,
                "user" => BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType.User,
                _ => null,
            };
        }
    }
}