
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsScheduleTriggerContextType
    {
        /// <summary>
        /// 
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsScheduleTriggerContextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsScheduleTriggerContextType value)
        {
            return value switch
            {
                BetaManagedAgentsScheduleTriggerContextType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsScheduleTriggerContextType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => BetaManagedAgentsScheduleTriggerContextType.Schedule,
                _ => null,
            };
        }
    }
}