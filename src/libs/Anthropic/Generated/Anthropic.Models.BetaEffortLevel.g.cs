
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
    public static class BetaEffortLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEffortLevel value)
        {
            return value switch
            {
                BetaEffortLevel.Low => "low",
                BetaEffortLevel.Medium => "medium",
                BetaEffortLevel.High => "high",
                BetaEffortLevel.Max => "max",
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
                "low" => BetaEffortLevel.Low,
                "medium" => BetaEffortLevel.Medium,
                "high" => BetaEffortLevel.High,
                "max" => BetaEffortLevel.Max,
                _ => null,
            };
        }
    }
}