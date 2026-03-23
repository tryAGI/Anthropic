
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// All possible effort levels.
    /// </summary>
    public enum BetaEffortLevel
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
    public static class BetaEffortLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEffortLevel value)
        {
            return value switch
            {
                BetaEffortLevel.High => "high",
                BetaEffortLevel.Low => "low",
                BetaEffortLevel.Max => "max",
                BetaEffortLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEffortLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaEffortLevel.High,
                "low" => BetaEffortLevel.Low,
                "max" => BetaEffortLevel.Max,
                "medium" => BetaEffortLevel.Medium,
                _ => null,
            };
        }
    }
}