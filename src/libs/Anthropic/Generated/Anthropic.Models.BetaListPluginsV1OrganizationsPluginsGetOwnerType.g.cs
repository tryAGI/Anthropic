
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListPluginsV1OrganizationsPluginsGetOwnerType
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
    public static class BetaListPluginsV1OrganizationsPluginsGetOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListPluginsV1OrganizationsPluginsGetOwnerType value)
        {
            return value switch
            {
                BetaListPluginsV1OrganizationsPluginsGetOwnerType.Organization => "organization",
                BetaListPluginsV1OrganizationsPluginsGetOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListPluginsV1OrganizationsPluginsGetOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaListPluginsV1OrganizationsPluginsGetOwnerType.Organization,
                "user" => BetaListPluginsV1OrganizationsPluginsGetOwnerType.User,
                _ => null,
            };
        }
    }
}