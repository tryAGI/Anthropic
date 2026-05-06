
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadStatusRescheduledEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusRescheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadStatusRescheduledEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadStatusRescheduledEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadStatusRescheduledEventType.SessionThreadStatusRescheduled => "session.thread_status_rescheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusRescheduledEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.thread_status_rescheduled" => BetaManagedAgentsSessionThreadStatusRescheduledEventType.SessionThreadStatusRescheduled,
                _ => null,
            };
        }
    }
}