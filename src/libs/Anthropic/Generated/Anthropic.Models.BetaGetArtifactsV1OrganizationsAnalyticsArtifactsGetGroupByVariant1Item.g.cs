
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item
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
    public static class BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item.Product => "product",
                BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item.Product,
                "rbac_group_id" => BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item.RbacGroupId,
                "user_id" => BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item.UserId,
                _ => null,
            };
        }
    }
}