
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Time bucket granularity.<br/>
    /// Default Value: 1d
    /// </summary>
    public enum BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth
    {
        /// <summary>
        ///
        /// </summary>
        x1d,
        /// <summary>
        ///
        /// </summary>
        x1h,
        /// <summary>
        ///
        /// </summary>
        x1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth value)
        {
            return value switch
            {
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth.x1d => "1d",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth.x1h => "1h",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth.x1d,
                "1h" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth.x1h,
                "1m" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth.x1m,
                _ => null,
            };
        }
    }
}