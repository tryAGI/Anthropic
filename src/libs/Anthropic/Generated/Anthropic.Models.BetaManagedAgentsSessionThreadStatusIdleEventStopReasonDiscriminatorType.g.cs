
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
        /// <summary>
        /// 
        /// </summary>
        RetriesExhausted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType.EndTurn => "end_turn",
                BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType.RequiresAction => "requires_action",
                BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType.RetriesExhausted => "retries_exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType.EndTurn,
                "requires_action" => BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType.RequiresAction,
                "retries_exhausted" => BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType.RetriesExhausted,
                _ => null,
            };
        }
    }
}