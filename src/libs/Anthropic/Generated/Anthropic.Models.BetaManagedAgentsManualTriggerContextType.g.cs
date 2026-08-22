
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsManualTriggerContextType
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsManualTriggerContextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsManualTriggerContextType value)
        {
            return value switch
            {
                BetaManagedAgentsManualTriggerContextType.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsManualTriggerContextType? ToEnum(string value)
        {
            return value switch
            {
                "manual" => BetaManagedAgentsManualTriggerContextType.Manual,
                _ => null,
            };
        }
    }
}