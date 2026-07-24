
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WorkspaceArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonErrorType.WorkspaceArchivedError => "workspace_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "workspace_archived_error" => BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonErrorType.WorkspaceArchivedError,
                _ => null,
            };
        }
    }
}