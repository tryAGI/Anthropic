
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEffortDiscriminatorType
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
    public static class BetaManagedAgentsEffortDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEffortDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsEffortDiscriminatorType.High => "high",
                BetaManagedAgentsEffortDiscriminatorType.Low => "low",
                BetaManagedAgentsEffortDiscriminatorType.Max => "max",
                BetaManagedAgentsEffortDiscriminatorType.Medium => "medium",
                BetaManagedAgentsEffortDiscriminatorType.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEffortDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaManagedAgentsEffortDiscriminatorType.High,
                "low" => BetaManagedAgentsEffortDiscriminatorType.Low,
                "max" => BetaManagedAgentsEffortDiscriminatorType.Max,
                "medium" => BetaManagedAgentsEffortDiscriminatorType.Medium,
                "xhigh" => BetaManagedAgentsEffortDiscriminatorType.Xhigh,
                _ => null,
            };
        }
    }
}