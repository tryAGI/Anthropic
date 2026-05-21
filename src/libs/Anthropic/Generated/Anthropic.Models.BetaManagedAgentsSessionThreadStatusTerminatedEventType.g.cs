
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadStatusTerminatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusTerminated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadStatusTerminatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadStatusTerminatedEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadStatusTerminatedEventType.SessionThreadStatusTerminated => "session.thread_status_terminated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusTerminatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.thread_status_terminated" => BetaManagedAgentsSessionThreadStatusTerminatedEventType.SessionThreadStatusTerminated,
                _ => null,
            };
        }
    }
}