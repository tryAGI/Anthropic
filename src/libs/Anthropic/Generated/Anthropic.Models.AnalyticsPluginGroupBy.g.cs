
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group plugin activity by.
    /// </summary>
    public enum AnalyticsPluginGroupBy
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
    public static class AnalyticsPluginGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsPluginGroupBy value)
        {
            return value switch
            {
                AnalyticsPluginGroupBy.Product => "product",
                AnalyticsPluginGroupBy.RbacGroupId => "rbac_group_id",
                AnalyticsPluginGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsPluginGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => AnalyticsPluginGroupBy.Product,
                "rbac_group_id" => AnalyticsPluginGroupBy.RbacGroupId,
                "user_id" => AnalyticsPluginGroupBy.UserId,
                _ => null,
            };
        }
    }
}