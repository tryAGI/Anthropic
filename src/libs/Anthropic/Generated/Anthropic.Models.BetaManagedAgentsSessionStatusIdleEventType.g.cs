
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionStatusIdleEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStatusIdle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionStatusIdleEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionStatusIdleEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionStatusIdleEventType.SessionStatusIdle => "session.status_idle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionStatusIdleEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.status_idle" => BetaManagedAgentsSessionStatusIdleEventType.SessionStatusIdle,
                _ => null,
            };
        }
    }
}