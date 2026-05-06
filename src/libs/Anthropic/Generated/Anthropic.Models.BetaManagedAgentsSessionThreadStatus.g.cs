
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// SessionThreadStatus enum
    /// </summary>
    public enum BetaManagedAgentsSessionThreadStatus
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
    public static class BetaManagedAgentsSessionThreadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadStatus value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadStatus.Idle => "idle",
                BetaManagedAgentsSessionThreadStatus.Rescheduling => "rescheduling",
                BetaManagedAgentsSessionThreadStatus.Running => "running",
                BetaManagedAgentsSessionThreadStatus.Terminated => "terminated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatus? ToEnum(string value)
        {
            return value switch
            {
                "idle" => BetaManagedAgentsSessionThreadStatus.Idle,
                "rescheduling" => BetaManagedAgentsSessionThreadStatus.Rescheduling,
                "running" => BetaManagedAgentsSessionThreadStatus.Running,
                "terminated" => BetaManagedAgentsSessionThreadStatus.Terminated,
                _ => null,
            };
        }
    }
}