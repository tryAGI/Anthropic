
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item
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
    public static class BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item value)
        {
            return value switch
            {
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item.Fast => "fast",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item.Fast,
                "standard" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item.Standard,
                _ => null,
            };
        }
    }
}