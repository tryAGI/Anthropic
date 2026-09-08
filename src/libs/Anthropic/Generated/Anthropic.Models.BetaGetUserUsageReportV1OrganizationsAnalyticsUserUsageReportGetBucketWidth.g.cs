
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth
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
    public static class BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth value)
        {
            return value switch
            {
                BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth.x1d => "1d",
                BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth.x1h => "1h",
                BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth.x1d,
                "1h" => BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth.x1h,
                "1m" => BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth.x1m,
                _ => null,
            };
        }
    }
}