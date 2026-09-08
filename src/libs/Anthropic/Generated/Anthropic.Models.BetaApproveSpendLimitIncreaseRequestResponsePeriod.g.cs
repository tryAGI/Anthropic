
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApproveSpendLimitIncreaseRequestResponsePeriod
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Monthly,
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApproveSpendLimitIncreaseRequestResponsePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApproveSpendLimitIncreaseRequestResponsePeriod value)
        {
            return value switch
            {
                BetaApproveSpendLimitIncreaseRequestResponsePeriod.Daily => "daily",
                BetaApproveSpendLimitIncreaseRequestResponsePeriod.Monthly => "monthly",
                BetaApproveSpendLimitIncreaseRequestResponsePeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApproveSpendLimitIncreaseRequestResponsePeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BetaApproveSpendLimitIncreaseRequestResponsePeriod.Daily,
                "monthly" => BetaApproveSpendLimitIncreaseRequestResponsePeriod.Monthly,
                "weekly" => BetaApproveSpendLimitIncreaseRequestResponsePeriod.Weekly,
                _ => null,
            };
        }
    }
}