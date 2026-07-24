
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventStartEventType
    {
        /// <summary>
        /// 
        /// </summary>
        EventStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEventStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventStartEventType value)
        {
            return value switch
            {
                BetaManagedAgentsEventStartEventType.EventStart => "event_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "event_start" => BetaManagedAgentsEventStartEventType.EventStart,
                _ => null,
            };
        }
    }
}