
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEffortMediumType
    {
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEffortMediumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEffortMediumType value)
        {
            return value switch
            {
                BetaManagedAgentsEffortMediumType.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEffortMediumType? ToEnum(string value)
        {
            return value switch
            {
                "medium" => BetaManagedAgentsEffortMediumType.Medium,
                _ => null,
            };
        }
    }
}