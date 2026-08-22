
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What triggered a deployment run.
    /// </summary>
    public enum BetaManagedAgentsTriggerType
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTriggerType value)
        {
            return value switch
            {
                BetaManagedAgentsTriggerType.Manual => "manual",
                BetaManagedAgentsTriggerType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "manual" => BetaManagedAgentsTriggerType.Manual,
                "schedule" => BetaManagedAgentsTriggerType.Schedule,
                _ => null,
            };
        }
    }
}