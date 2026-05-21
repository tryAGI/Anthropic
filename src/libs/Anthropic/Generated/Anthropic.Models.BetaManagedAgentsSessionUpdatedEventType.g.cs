
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionUpdatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionUpdatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionUpdatedEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionUpdatedEventType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionUpdatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => BetaManagedAgentsSessionUpdatedEventType.SessionUpdated,
                _ => null,
            };
        }
    }
}