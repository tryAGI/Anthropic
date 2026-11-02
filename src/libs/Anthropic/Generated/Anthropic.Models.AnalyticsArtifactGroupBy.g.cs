
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A dimension to group artifact activity by.
    /// </summary>
    public enum AnalyticsArtifactGroupBy
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
    public static class AnalyticsArtifactGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsArtifactGroupBy value)
        {
            return value switch
            {
                AnalyticsArtifactGroupBy.Product => "product",
                AnalyticsArtifactGroupBy.RbacGroupId => "rbac_group_id",
                AnalyticsArtifactGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsArtifactGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "product" => AnalyticsArtifactGroupBy.Product,
                "rbac_group_id" => AnalyticsArtifactGroupBy.RbacGroupId,
                "user_id" => AnalyticsArtifactGroupBy.UserId,
                _ => null,
            };
        }
    }
}