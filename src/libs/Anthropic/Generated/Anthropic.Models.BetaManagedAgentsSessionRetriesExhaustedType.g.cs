
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionRetriesExhaustedType
    {
        /// <summary>
        /// 
        /// </summary>
        RetriesExhausted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionRetriesExhaustedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionRetriesExhaustedType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionRetriesExhaustedType.RetriesExhausted => "retries_exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionRetriesExhaustedType? ToEnum(string value)
        {
            return value switch
            {
                "retries_exhausted" => BetaManagedAgentsSessionRetriesExhaustedType.RetriesExhausted,
                _ => null,
            };
        }
    }
}