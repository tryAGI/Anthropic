
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitIncreaseRequestSchemaPeriod
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
    public static class BetaSpendLimitIncreaseRequestSchemaPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitIncreaseRequestSchemaPeriod value)
        {
            return value switch
            {
                BetaSpendLimitIncreaseRequestSchemaPeriod.Daily => "daily",
                BetaSpendLimitIncreaseRequestSchemaPeriod.Monthly => "monthly",
                BetaSpendLimitIncreaseRequestSchemaPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitIncreaseRequestSchemaPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BetaSpendLimitIncreaseRequestSchemaPeriod.Daily,
                "monthly" => BetaSpendLimitIncreaseRequestSchemaPeriod.Monthly,
                "weekly" => BetaSpendLimitIncreaseRequestSchemaPeriod.Weekly,
                _ => null,
            };
        }
    }
}