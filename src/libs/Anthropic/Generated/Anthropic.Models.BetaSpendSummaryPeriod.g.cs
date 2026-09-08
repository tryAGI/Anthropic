
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Period this row's effective limit and spend are reported for.
    /// </summary>
    public enum BetaSpendSummaryPeriod
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
    public static class BetaSpendSummaryPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendSummaryPeriod value)
        {
            return value switch
            {
                BetaSpendSummaryPeriod.Daily => "daily",
                BetaSpendSummaryPeriod.Monthly => "monthly",
                BetaSpendSummaryPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendSummaryPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BetaSpendSummaryPeriod.Daily,
                "monthly" => BetaSpendSummaryPeriod.Monthly,
                "weekly" => BetaSpendSummaryPeriod.Weekly,
                _ => null,
            };
        }
    }
}