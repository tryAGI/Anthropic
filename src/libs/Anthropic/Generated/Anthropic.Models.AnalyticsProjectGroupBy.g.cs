
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group chat project activity by.
    /// </summary>
    public enum AnalyticsProjectGroupBy
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
    public static class AnalyticsProjectGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsProjectGroupBy value)
        {
            return value switch
            {
                AnalyticsProjectGroupBy.RbacGroupId => "rbac_group_id",
                AnalyticsProjectGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsProjectGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "rbac_group_id" => AnalyticsProjectGroupBy.RbacGroupId,
                "user_id" => AnalyticsProjectGroupBy.UserId,
                _ => null,
            };
        }
    }
}