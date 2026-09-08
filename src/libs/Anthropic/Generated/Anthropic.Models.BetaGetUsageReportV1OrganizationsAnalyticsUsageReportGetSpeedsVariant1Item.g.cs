
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item
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
    public static class BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item value)
        {
            return value switch
            {
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item.Fast => "fast",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item.Fast,
                "standard" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item.Standard,
                _ => null,
            };
        }
    }
}