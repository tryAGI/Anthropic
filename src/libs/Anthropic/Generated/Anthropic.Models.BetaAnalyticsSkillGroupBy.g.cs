
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group skill activity by.
    /// </summary>
    public enum BetaAnalyticsSkillGroupBy
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
    public static class BetaAnalyticsSkillGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsSkillGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsSkillGroupBy.Product => "product",
                BetaAnalyticsSkillGroupBy.RbacGroupId => "rbac_group_id",
                BetaAnalyticsSkillGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsSkillGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaAnalyticsSkillGroupBy.Product,
                "rbac_group_id" => BetaAnalyticsSkillGroupBy.RbacGroupId,
                "user_id" => BetaAnalyticsSkillGroupBy.UserId,
                _ => null,
            };
        }
    }
}