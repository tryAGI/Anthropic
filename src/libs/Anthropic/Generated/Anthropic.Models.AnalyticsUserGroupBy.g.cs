
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group user activity by.
    /// </summary>
    public enum AnalyticsUserGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        RbacGroupId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsUserGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsUserGroupBy value)
        {
            return value switch
            {
                AnalyticsUserGroupBy.RbacGroupId => "rbac_group_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsUserGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "rbac_group_id" => AnalyticsUserGroupBy.RbacGroupId,
                _ => null,
            };
        }
    }
}