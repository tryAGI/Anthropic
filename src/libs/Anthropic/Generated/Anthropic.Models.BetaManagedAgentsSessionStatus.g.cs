
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// SessionStatus enum
    /// </summary>
    public enum BetaManagedAgentsSessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Rescheduling,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Terminated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionStatus value)
        {
            return value switch
            {
                BetaManagedAgentsSessionStatus.Idle => "idle",
                BetaManagedAgentsSessionStatus.Rescheduling => "rescheduling",
                BetaManagedAgentsSessionStatus.Running => "running",
                BetaManagedAgentsSessionStatus.Terminated => "terminated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "idle" => BetaManagedAgentsSessionStatus.Idle,
                "rescheduling" => BetaManagedAgentsSessionStatus.Rescheduling,
                "running" => BetaManagedAgentsSessionStatus.Running,
                "terminated" => BetaManagedAgentsSessionStatus.Terminated,
                _ => null,
            };
        }
    }
}