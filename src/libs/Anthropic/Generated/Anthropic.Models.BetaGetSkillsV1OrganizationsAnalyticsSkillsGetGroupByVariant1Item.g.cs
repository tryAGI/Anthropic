
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item
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
    public static class BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item.Product => "product",
                BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item.Product,
                "rbac_group_id" => BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item.RbacGroupId,
                "user_id" => BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item.UserId,
                _ => null,
            };
        }
    }
}