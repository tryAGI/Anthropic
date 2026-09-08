
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        RbacGroupId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "rbac_group_id" => BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item.RbacGroupId,
                _ => null,
            };
        }
    }
}