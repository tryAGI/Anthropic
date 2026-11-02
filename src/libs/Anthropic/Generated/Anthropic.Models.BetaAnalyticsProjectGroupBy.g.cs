
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group chat project activity by.
    /// </summary>
    public enum BetaAnalyticsProjectGroupBy
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
    public static class BetaAnalyticsProjectGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsProjectGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsProjectGroupBy.RbacGroupId => "rbac_group_id",
                BetaAnalyticsProjectGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsProjectGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "rbac_group_id" => BetaAnalyticsProjectGroupBy.RbacGroupId,
                "user_id" => BetaAnalyticsProjectGroupBy.UserId,
                _ => null,
            };
        }
    }
}