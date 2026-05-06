
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadCreatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionThreadCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadCreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadCreatedEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadCreatedEventType.SessionThreadCreated => "session.thread_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadCreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.thread_created" => BetaManagedAgentsSessionThreadCreatedEventType.SessionThreadCreated,
                _ => null,
            };
        }
    }
}