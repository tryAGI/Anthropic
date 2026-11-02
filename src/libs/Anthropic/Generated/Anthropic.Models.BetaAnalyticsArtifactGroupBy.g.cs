
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group artifact activity by.
    /// </summary>
    public enum BetaAnalyticsArtifactGroupBy
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
    public static class BetaAnalyticsArtifactGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsArtifactGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsArtifactGroupBy.Product => "product",
                BetaAnalyticsArtifactGroupBy.RbacGroupId => "rbac_group_id",
                BetaAnalyticsArtifactGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsArtifactGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => BetaAnalyticsArtifactGroupBy.Product,
                "rbac_group_id" => BetaAnalyticsArtifactGroupBy.RbacGroupId,
                "user_id" => BetaAnalyticsArtifactGroupBy.UserId,
                _ => null,
            };
        }
    }
}