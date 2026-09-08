
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder
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
    public static class BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder value)
        {
            return value switch
            {
                BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder.Asc => "asc",
                BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder.Asc,
                "desc" => BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder.Desc,
                _ => null,
            };
        }
    }
}