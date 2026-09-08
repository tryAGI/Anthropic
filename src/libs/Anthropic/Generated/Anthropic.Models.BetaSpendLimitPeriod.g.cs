
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Length of the window the limit resets over. `amount` caps spend within each period.
    /// </summary>
    public enum BetaSpendLimitPeriod
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
    public static class BetaSpendLimitPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitPeriod value)
        {
            return value switch
            {
                BetaSpendLimitPeriod.Daily => "daily",
                BetaSpendLimitPeriod.Monthly => "monthly",
                BetaSpendLimitPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BetaSpendLimitPeriod.Daily,
                "monthly" => BetaSpendLimitPeriod.Monthly,
                "weekly" => BetaSpendLimitPeriod.Weekly,
                _ => null,
            };
        }
    }
}