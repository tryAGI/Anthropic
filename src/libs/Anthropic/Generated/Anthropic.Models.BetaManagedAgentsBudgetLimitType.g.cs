
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsBudgetLimitType
    {
        /// <summary>
        ///
        /// </summary>
        Limit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsBudgetLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsBudgetLimitType value)
        {
            return value switch
            {
                BetaManagedAgentsBudgetLimitType.Limit => "limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsBudgetLimitType? ToEnum(string value)
        {
            return value switch
            {
                "limit" => BetaManagedAgentsBudgetLimitType.Limit,
                _ => null,
            };
        }
    }
}