
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Current state of the work item (active/stopping/stopped)
    /// </summary>
    public enum BetaSelfHostedWorkHeartbeatResponseState
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
    public static class BetaSelfHostedWorkHeartbeatResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSelfHostedWorkHeartbeatResponseState value)
        {
            return value switch
            {
                BetaSelfHostedWorkHeartbeatResponseState.Active => "active",
                BetaSelfHostedWorkHeartbeatResponseState.Queued => "queued",
                BetaSelfHostedWorkHeartbeatResponseState.Starting => "starting",
                BetaSelfHostedWorkHeartbeatResponseState.Stopped => "stopped",
                BetaSelfHostedWorkHeartbeatResponseState.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSelfHostedWorkHeartbeatResponseState? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaSelfHostedWorkHeartbeatResponseState.Active,
                "queued" => BetaSelfHostedWorkHeartbeatResponseState.Queued,
                "starting" => BetaSelfHostedWorkHeartbeatResponseState.Starting,
                "stopped" => BetaSelfHostedWorkHeartbeatResponseState.Stopped,
                "stopping" => BetaSelfHostedWorkHeartbeatResponseState.Stopping,
                _ => null,
            };
        }
    }
}