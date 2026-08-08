
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Current state of the work item
    /// </summary>
    public enum BetaSelfHostedWorkState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Stopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSelfHostedWorkStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSelfHostedWorkState value)
        {
            return value switch
            {
                BetaSelfHostedWorkState.Active => "active",
                BetaSelfHostedWorkState.Queued => "queued",
                BetaSelfHostedWorkState.Starting => "starting",
                BetaSelfHostedWorkState.Stopped => "stopped",
                BetaSelfHostedWorkState.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSelfHostedWorkState? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaSelfHostedWorkState.Active,
                "queued" => BetaSelfHostedWorkState.Queued,
                "starting" => BetaSelfHostedWorkState.Starting,
                "stopped" => BetaSelfHostedWorkState.Stopped,
                "stopping" => BetaSelfHostedWorkState.Stopping,
                _ => null,
            };
        }
    }
}