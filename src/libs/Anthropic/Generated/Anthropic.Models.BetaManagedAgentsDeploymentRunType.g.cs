
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeploymentRunType
    {
        /// <summary>
        /// 
        /// </summary>
        DeploymentRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeploymentRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentRunType value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentRunType.DeploymentRun => "deployment_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentRunType? ToEnum(string value)
        {
            return value switch
            {
                "deployment_run" => BetaManagedAgentsDeploymentRunType.DeploymentRun,
                _ => null,
            };
        }
    }
}