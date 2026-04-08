
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionStatusRunningEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStatusRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionStatusRunningEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionStatusRunningEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionStatusRunningEventType.SessionStatusRunning => "session.status_running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionStatusRunningEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.status_running" => BetaManagedAgentsSessionStatusRunningEventType.SessionStatusRunning,
                _ => null,
            };
        }
    }
}