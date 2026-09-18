
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Lifecycle status of a deployment.
    /// </summary>
    public enum BetaManagedAgentsDeploymentStatus
    {
        /// <summary>
        /// The deployment is active and can run sessions. Archived deployments also report this status; check `archived_at` to distinguish them.
        /// </summary>
        Active,
        /// <summary>
        /// The deployment is paused. Autonomous triggers are suppressed; manual runs are still permitted.
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeploymentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentStatus value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentStatus.Active => "active",
                BetaManagedAgentsDeploymentStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaManagedAgentsDeploymentStatus.Active,
                "paused" => BetaManagedAgentsDeploymentStatus.Paused,
                _ => null,
            };
        }
    }
}