
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApproveSpendLimitIncreaseRequestParamsPeriod
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
    public static class BetaApproveSpendLimitIncreaseRequestParamsPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApproveSpendLimitIncreaseRequestParamsPeriod value)
        {
            return value switch
            {
                BetaApproveSpendLimitIncreaseRequestParamsPeriod.Daily => "daily",
                BetaApproveSpendLimitIncreaseRequestParamsPeriod.Monthly => "monthly",
                BetaApproveSpendLimitIncreaseRequestParamsPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApproveSpendLimitIncreaseRequestParamsPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BetaApproveSpendLimitIncreaseRequestParamsPeriod.Daily,
                "monthly" => BetaApproveSpendLimitIncreaseRequestParamsPeriod.Monthly,
                "weekly" => BetaApproveSpendLimitIncreaseRequestParamsPeriod.Weekly,
                _ => null,
            };
        }
    }
}