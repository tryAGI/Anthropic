
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadStatusRunningEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadStatusRunningEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadStatusRunningEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadStatusRunningEventType.SessionThreadStatusRunning => "session.thread_status_running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusRunningEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.thread_status_running" => BetaManagedAgentsSessionThreadStatusRunningEventType.SessionThreadStatusRunning,
                _ => null,
            };
        }
    }
}