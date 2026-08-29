
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsBudgetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Limit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsBudgetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsBudgetDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsBudgetDiscriminatorType.Limit => "limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsBudgetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "limit" => BetaManagedAgentsBudgetDiscriminatorType.Limit,
                _ => null,
            };
        }
    }
}