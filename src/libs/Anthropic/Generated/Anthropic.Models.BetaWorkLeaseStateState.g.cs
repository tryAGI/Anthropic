
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Current state of the work item
    /// </summary>
    public enum BetaWorkLeaseStateState
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
    public static class BetaWorkLeaseStateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkLeaseStateState value)
        {
            return value switch
            {
                BetaWorkLeaseStateState.Active => "active",
                BetaWorkLeaseStateState.Queued => "queued",
                BetaWorkLeaseStateState.Starting => "starting",
                BetaWorkLeaseStateState.Stopped => "stopped",
                BetaWorkLeaseStateState.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkLeaseStateState? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaWorkLeaseStateState.Active,
                "queued" => BetaWorkLeaseStateState.Queued,
                "starting" => BetaWorkLeaseStateState.Starting,
                "stopped" => BetaWorkLeaseStateState.Stopped,
                "stopping" => BetaWorkLeaseStateState.Stopping,
                _ => null,
            };
        }
    }
}