
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item
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
    public static class BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item.Product => "product",
                BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item.Product,
                "rbac_group_id" => BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item.RbacGroupId,
                "user_id" => BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item.UserId,
                _ => null,
            };
        }
    }
}