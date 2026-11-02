
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group plugin activity by.
    /// </summary>
    public enum BetaAnalyticsPluginGroupBy
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
    public static class BetaAnalyticsPluginGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsPluginGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsPluginGroupBy.Product => "product",
                BetaAnalyticsPluginGroupBy.RbacGroupId => "rbac_group_id",
                BetaAnalyticsPluginGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsPluginGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaAnalyticsPluginGroupBy.Product,
                "rbac_group_id" => BetaAnalyticsPluginGroupBy.RbacGroupId,
                "user_id" => BetaAnalyticsPluginGroupBy.UserId,
                _ => null,
            };
        }
    }
}