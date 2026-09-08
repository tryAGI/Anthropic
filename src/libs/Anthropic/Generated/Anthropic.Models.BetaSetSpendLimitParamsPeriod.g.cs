
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSetSpendLimitParamsPeriod
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
    public static class BetaSetSpendLimitParamsPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSetSpendLimitParamsPeriod value)
        {
            return value switch
            {
                BetaSetSpendLimitParamsPeriod.Daily => "daily",
                BetaSetSpendLimitParamsPeriod.Monthly => "monthly",
                BetaSetSpendLimitParamsPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSetSpendLimitParamsPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BetaSetSpendLimitParamsPeriod.Daily,
                "monthly" => BetaSetSpendLimitParamsPeriod.Monthly,
                "weekly" => BetaSetSpendLimitParamsPeriod.Weekly,
                _ => null,
            };
        }
    }
}