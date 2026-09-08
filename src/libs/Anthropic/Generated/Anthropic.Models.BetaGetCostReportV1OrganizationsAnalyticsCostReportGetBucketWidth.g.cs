
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Time bucket granularity.<br/>
    /// Default Value: 1d
    /// </summary>
    public enum BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth
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
    public static class BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth value)
        {
            return value switch
            {
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth.x1d => "1d",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth.x1h => "1h",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth.x1d,
                "1h" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth.x1h,
                "1m" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth.x1m,
                _ => null,
            };
        }
    }
}