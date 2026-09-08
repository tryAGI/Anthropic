
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth
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
    public static class BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth value)
        {
            return value switch
            {
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth.x1d => "1d",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth.x1h => "1h",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth.x1d,
                "1h" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth.x1h,
                "1m" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth.x1m,
                _ => null,
            };
        }
    }
}