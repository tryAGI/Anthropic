
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsOutcomeEvaluationResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        OutcomeEvaluation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsOutcomeEvaluationResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsOutcomeEvaluationResourceType value)
        {
            return value switch
            {
                BetaManagedAgentsOutcomeEvaluationResourceType.OutcomeEvaluation => "outcome_evaluation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsOutcomeEvaluationResourceType? ToEnum(string value)
        {
            return value switch
            {
                "outcome_evaluation" => BetaManagedAgentsOutcomeEvaluationResourceType.OutcomeEvaluation,
                _ => null,
            };
        }
    }
}