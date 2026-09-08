
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        RbacGroupId,
        /// <summary>
        ///
        /// </summary>
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "rbac_group_id" => BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item.RbacGroupId,
                "user_id" => BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item.UserId,
                _ => null,
            };
        }
    }
}