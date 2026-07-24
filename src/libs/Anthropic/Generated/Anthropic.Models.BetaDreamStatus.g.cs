
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Lifecycle status of a Dream.
    /// </summary>
    public enum BetaDreamStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
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