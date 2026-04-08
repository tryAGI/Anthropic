
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSpanModelRequestEndEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SpanModelRequestEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSpanModelRequestEndEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSpanModelRequestEndEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSpanModelRequestEndEventType.SpanModelRequestEnd => "span.model_request_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSpanModelRequestEndEventType? ToEnum(string value)
        {
            return value switch
            {
                "span.model_request_end" => BetaManagedAgentsSpanModelRequestEndEventType.SpanModelRequestEnd,
                _ => null,
            };
        }
    }
}