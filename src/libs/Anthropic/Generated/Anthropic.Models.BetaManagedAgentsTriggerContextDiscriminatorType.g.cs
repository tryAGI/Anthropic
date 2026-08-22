
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsTriggerContextDiscriminatorType
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
    public static class BetaManagedAgentsTriggerContextDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTriggerContextDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsTriggerContextDiscriminatorType.Manual => "manual",
                BetaManagedAgentsTriggerContextDiscriminatorType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTriggerContextDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "manual" => BetaManagedAgentsTriggerContextDiscriminatorType.Manual,
                "schedule" => BetaManagedAgentsTriggerContextDiscriminatorType.Schedule,
                _ => null,
            };
        }
    }
}