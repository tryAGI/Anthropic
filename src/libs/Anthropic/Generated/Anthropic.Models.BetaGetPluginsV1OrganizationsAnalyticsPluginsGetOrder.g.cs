
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder
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
    public static class BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder value)
        {
            return value switch
            {
                BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder.Asc => "asc",
                BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder.Asc,
                "desc" => BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder.Desc,
                _ => null,
            };
        }
    }
}