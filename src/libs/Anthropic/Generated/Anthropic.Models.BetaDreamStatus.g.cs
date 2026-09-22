
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where a dream is in its lifecycle.<br/>
    /// `completed`, `failed`, and `canceled` are final: once a dream has one of these statuses, its status doesn't change again.<br/>
    /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#lifecycle) for what each status means.
    /// </summary>
    public enum BetaDreamStatus
    {
        /// <summary>
        /// A cancel request stopped the dream before it reached `completed` or `failed`.<br/>
        /// If `outputs` references a memory store, that memory store keeps what the dream wrote. `usage` can keep changing after the cancel.
        /// </summary>
        Canceled,
        /// <summary>
        /// The dream finished and its output memory store holds the complete result.
        /// </summary>
        Completed,
        /// <summary>
        /// The dream stopped with an error, which `error` describes.<br/>
        /// If `outputs` references a memory store, that memory store keeps what the dream wrote before it stopped.
        /// </summary>
        Failed,
        /// <summary>
        /// The dream is waiting to start and hasn't read its inputs yet.<br/>
        /// `outputs` is empty and every `usage` count is zero.
        /// </summary>
        Pending,
        /// <summary>
        /// The dream is reading its inputs and writing its result.<br/>
        /// `usage` updates while the dream has this status.
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamStatus value)
        {
            return value switch
            {
                BetaDreamStatus.Canceled => "canceled",
                BetaDreamStatus.Completed => "completed",
                BetaDreamStatus.Failed => "failed",
                BetaDreamStatus.Pending => "pending",
                BetaDreamStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => BetaDreamStatus.Canceled,
                "completed" => BetaDreamStatus.Completed,
                "failed" => BetaDreamStatus.Failed,
                "pending" => BetaDreamStatus.Pending,
                "running" => BetaDreamStatus.Running,
                _ => null,
            };
        }
    }
}