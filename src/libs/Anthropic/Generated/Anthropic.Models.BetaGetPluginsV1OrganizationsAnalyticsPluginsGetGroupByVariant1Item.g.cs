
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Product,
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
    public static class BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item.Product => "product",
                BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item.Product,
                "rbac_group_id" => BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item.RbacGroupId,
                "user_id" => BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item.UserId,
                _ => null,
            };
        }
    }
}