
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group user activity by.
    /// </summary>
    public enum BetaAnalyticsUserGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        RbacGroupId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsUserGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUserGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsUserGroupBy.RbacGroupId => "rbac_group_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUserGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "rbac_group_id" => BetaAnalyticsUserGroupBy.RbacGroupId,
                _ => null,
            };
        }
    }
}