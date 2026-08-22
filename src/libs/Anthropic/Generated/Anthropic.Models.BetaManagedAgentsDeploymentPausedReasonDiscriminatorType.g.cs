
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeploymentPausedReasonDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeploymentPausedReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentPausedReasonDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentPausedReasonDiscriminatorType.Error => "error",
                BetaManagedAgentsDeploymentPausedReasonDiscriminatorType.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaManagedAgentsDeploymentPausedReasonDiscriminatorType.Error,
                "manual" => BetaManagedAgentsDeploymentPausedReasonDiscriminatorType.Manual,
                _ => null,
            };
        }
    }
}