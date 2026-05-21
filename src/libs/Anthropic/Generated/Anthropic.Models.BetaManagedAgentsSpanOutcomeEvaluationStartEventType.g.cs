
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSpanOutcomeEvaluationStartEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SpanOutcomeEvaluationStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSpanOutcomeEvaluationStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSpanOutcomeEvaluationStartEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSpanOutcomeEvaluationStartEventType.SpanOutcomeEvaluationStart => "span.outcome_evaluation_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSpanOutcomeEvaluationStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "span.outcome_evaluation_start" => BetaManagedAgentsSpanOutcomeEvaluationStartEventType.SpanOutcomeEvaluationStart,
                _ => null,
            };
        }
    }
}