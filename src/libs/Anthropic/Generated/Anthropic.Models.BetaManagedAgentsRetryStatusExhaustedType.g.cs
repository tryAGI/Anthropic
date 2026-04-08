
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsRetryStatusExhaustedType
    {
        /// <summary>
        /// 
        /// </summary>
        Exhausted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsRetryStatusExhaustedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsRetryStatusExhaustedType value)
        {
            return value switch
            {
                BetaManagedAgentsRetryStatusExhaustedType.Exhausted => "exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsRetryStatusExhaustedType? ToEnum(string value)
        {
            return value switch
            {
                "exhausted" => BetaManagedAgentsRetryStatusExhaustedType.Exhausted,
                _ => null,
            };
        }
    }
}