
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item value)
        {
            return value switch
            {
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item.Fast => "fast",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item.Fast,
                "standard" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item.Standard,
                _ => null,
            };
        }
    }
}