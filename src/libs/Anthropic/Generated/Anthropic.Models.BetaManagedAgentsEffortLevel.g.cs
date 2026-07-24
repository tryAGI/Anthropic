
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How hard Claude works on each turn. Higher levels favor reasoning depth over latency. Not all models accept every level; invalid combinations are rejected at create time.
    /// </summary>
    public enum BetaManagedAgentsEffortLevel
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
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEffortLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEffortLevel value)
        {
            return value switch
            {
                BetaManagedAgentsEffortLevel.High => "high",
                BetaManagedAgentsEffortLevel.Low => "low",
                BetaManagedAgentsEffortLevel.Max => "max",
                BetaManagedAgentsEffortLevel.Medium => "medium",
                BetaManagedAgentsEffortLevel.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEffortLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaManagedAgentsEffortLevel.High,
                "low" => BetaManagedAgentsEffortLevel.Low,
                "max" => BetaManagedAgentsEffortLevel.Max,
                "medium" => BetaManagedAgentsEffortLevel.Medium,
                "xhigh" => BetaManagedAgentsEffortLevel.Xhigh,
                _ => null,
            };
        }
    }
}