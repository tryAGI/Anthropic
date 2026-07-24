
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEffortHighType
    {
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEffortHighTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEffortHighType value)
        {
            return value switch
            {
                BetaManagedAgentsEffortHighType.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEffortHighType? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaManagedAgentsEffortHighType.High,
                _ => null,
            };
        }
    }
}