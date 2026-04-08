
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionErrorEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionErrorEventType.SessionError => "session.error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.error" => BetaManagedAgentsSessionErrorEventType.SessionError,
                _ => null,
            };
        }
    }
}