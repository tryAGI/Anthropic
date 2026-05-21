
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadStatusIdleEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusIdle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadStatusIdleEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadStatusIdleEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadStatusIdleEventType.SessionThreadStatusIdle => "session.thread_status_idle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusIdleEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.thread_status_idle" => BetaManagedAgentsSessionThreadStatusIdleEventType.SessionThreadStatusIdle,
                _ => null,
            };
        }
    }
}