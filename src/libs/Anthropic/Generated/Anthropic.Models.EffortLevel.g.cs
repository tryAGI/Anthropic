
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// All possible effort levels.
    /// </summary>
    public enum EffortLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EffortLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EffortLevel value)
        {
            return value switch
            {
                EffortLevel.High => "high",
                EffortLevel.Low => "low",
                EffortLevel.Max => "max",
                EffortLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EffortLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => EffortLevel.High,
                "low" => EffortLevel.Low,
                "max" => EffortLevel.Max,
                "medium" => EffortLevel.Medium,
                _ => null,
            };
        }
    }
}