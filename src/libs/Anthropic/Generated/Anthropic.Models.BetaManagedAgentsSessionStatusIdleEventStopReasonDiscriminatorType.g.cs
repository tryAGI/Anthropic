
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType
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
    public static class BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType.EndTurn => "end_turn",
                BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType.RequiresAction => "requires_action",
                BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType.RetriesExhausted => "retries_exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType.EndTurn,
                "requires_action" => BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType.RequiresAction,
                "retries_exhausted" => BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType.RetriesExhausted,
                _ => null,
            };
        }
    }
}