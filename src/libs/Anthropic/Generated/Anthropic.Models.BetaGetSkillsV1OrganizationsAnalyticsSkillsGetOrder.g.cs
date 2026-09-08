
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder value)
        {
            return value switch
            {
                BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder.Asc => "asc",
                BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder.Asc,
                "desc" => BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder.Desc,
                _ => null,
            };
        }
    }
}