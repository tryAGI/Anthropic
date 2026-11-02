
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendLimitPeriod
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
    public static class SpendLimitPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitPeriod value)
        {
            return value switch
            {
                SpendLimitPeriod.Daily => "daily",
                SpendLimitPeriod.Monthly => "monthly",
                SpendLimitPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => SpendLimitPeriod.Daily,
                "monthly" => SpendLimitPeriod.Monthly,
                "weekly" => SpendLimitPeriod.Weekly,
                _ => null,
            };
        }
    }
}