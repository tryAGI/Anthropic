
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group skill activity by.
    /// </summary>
    public enum AnalyticsSkillGroupBy
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
    public static class AnalyticsSkillGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsSkillGroupBy value)
        {
            return value switch
            {
                AnalyticsSkillGroupBy.Product => "product",
                AnalyticsSkillGroupBy.RbacGroupId => "rbac_group_id",
                AnalyticsSkillGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsSkillGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => AnalyticsSkillGroupBy.Product,
                "rbac_group_id" => AnalyticsSkillGroupBy.RbacGroupId,
                "user_id" => AnalyticsSkillGroupBy.UserId,
                _ => null,
            };
        }
    }
}