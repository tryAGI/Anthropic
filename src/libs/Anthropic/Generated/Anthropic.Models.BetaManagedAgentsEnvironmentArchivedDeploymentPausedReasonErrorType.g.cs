
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonErrorType.EnvironmentArchivedError => "environment_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "environment_archived_error" => BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonErrorType.EnvironmentArchivedError,
                _ => null,
            };
        }
    }
}