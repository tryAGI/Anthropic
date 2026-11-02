
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group connector activity by.
    /// </summary>
    public enum BetaAnalyticsConnectorGroupBy
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
    public static class BetaAnalyticsConnectorGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsConnectorGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsConnectorGroupBy.Product => "product",
                BetaAnalyticsConnectorGroupBy.RbacGroupId => "rbac_group_id",
                BetaAnalyticsConnectorGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsConnectorGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaAnalyticsConnectorGroupBy.Product,
                "rbac_group_id" => BetaAnalyticsConnectorGroupBy.RbacGroupId,
                "user_id" => BetaAnalyticsConnectorGroupBy.UserId,
                _ => null,
            };
        }
    }
}