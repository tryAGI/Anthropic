
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSpanOutcomeEvaluationEndEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SpanOutcomeEvaluationEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSpanOutcomeEvaluationEndEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSpanOutcomeEvaluationEndEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSpanOutcomeEvaluationEndEventType.SpanOutcomeEvaluationEnd => "span.outcome_evaluation_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSpanOutcomeEvaluationEndEventType? ToEnum(string value)
        {
            return value switch
            {
                "span.outcome_evaluation_end" => BetaManagedAgentsSpanOutcomeEvaluationEndEventType.SpanOutcomeEvaluationEnd,
                _ => null,
            };
        }
    }
}