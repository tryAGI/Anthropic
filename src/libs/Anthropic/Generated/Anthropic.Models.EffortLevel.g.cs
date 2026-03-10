
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
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Max,
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
                EffortLevel.Low => "low",
                EffortLevel.Medium => "medium",
                EffortLevel.High => "high",
                EffortLevel.Max => "max",
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
                "low" => EffortLevel.Low,
                "medium" => EffortLevel.Medium,
                "high" => EffortLevel.High,
                "max" => EffortLevel.Max,
                _ => null,
            };
        }
    }
}