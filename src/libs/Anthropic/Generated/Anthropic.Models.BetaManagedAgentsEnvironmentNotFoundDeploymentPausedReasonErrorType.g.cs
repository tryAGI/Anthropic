
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonErrorType.EnvironmentNotFoundError => "environment_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "environment_not_found_error" => BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonErrorType.EnvironmentNotFoundError,
                _ => null,
            };
        }
    }
}