
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        EventDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEventDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventDeltaEventType value)
        {
            return value switch
            {
                BetaManagedAgentsEventDeltaEventType.EventDelta => "event_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "event_delta" => BetaManagedAgentsEventDeltaEventType.EventDelta,
                _ => null,
            };
        }
    }
}