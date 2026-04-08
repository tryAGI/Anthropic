
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionStatusTerminatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStatusTerminated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionStatusTerminatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionStatusTerminatedEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionStatusTerminatedEventType.SessionStatusTerminated => "session.status_terminated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionStatusTerminatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.status_terminated" => BetaManagedAgentsSessionStatusTerminatedEventType.SessionStatusTerminated,
                _ => null,
            };
        }
    }
}