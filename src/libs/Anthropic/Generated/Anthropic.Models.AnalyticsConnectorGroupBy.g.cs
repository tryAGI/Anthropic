
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group connector activity by.
    /// </summary>
    public enum AnalyticsConnectorGroupBy
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
    public static class AnalyticsConnectorGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsConnectorGroupBy value)
        {
            return value switch
            {
                AnalyticsConnectorGroupBy.Product => "product",
                AnalyticsConnectorGroupBy.RbacGroupId => "rbac_group_id",
                AnalyticsConnectorGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsConnectorGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => AnalyticsConnectorGroupBy.Product,
                "rbac_group_id" => AnalyticsConnectorGroupBy.RbacGroupId,
                "user_id" => AnalyticsConnectorGroupBy.UserId,
                _ => null,
            };
        }
    }
}