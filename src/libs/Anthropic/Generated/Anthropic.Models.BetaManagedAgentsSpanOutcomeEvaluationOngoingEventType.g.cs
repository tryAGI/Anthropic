
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SpanOutcomeEvaluationOngoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSpanOutcomeEvaluationOngoingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType.SpanOutcomeEvaluationOngoing => "span.outcome_evaluation_ongoing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType? ToEnum(string value)
        {
            return value switch
            {
                "span.outcome_evaluation_ongoing" => BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType.SpanOutcomeEvaluationOngoing,
                _ => null,
            };
        }
    }
}