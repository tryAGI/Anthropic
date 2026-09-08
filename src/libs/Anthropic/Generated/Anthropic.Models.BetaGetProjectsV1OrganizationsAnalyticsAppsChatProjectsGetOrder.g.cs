
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder
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
    public static class BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder value)
        {
            return value switch
            {
                BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder.Asc => "asc",
                BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder.Asc,
                "desc" => BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder.Desc,
                _ => null,
            };
        }
    }
}