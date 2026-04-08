
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionStatusRescheduledEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStatusRescheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionStatusRescheduledEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionStatusRescheduledEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionStatusRescheduledEventType.SessionStatusRescheduled => "session.status_rescheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionStatusRescheduledEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.status_rescheduled" => BetaManagedAgentsSessionStatusRescheduledEventType.SessionStatusRescheduled,
                _ => null,
            };
        }
    }
}