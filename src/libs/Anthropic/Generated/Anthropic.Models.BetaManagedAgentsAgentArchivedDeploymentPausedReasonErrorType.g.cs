
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType.AgentArchivedError => "agent_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_archived_error" => BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType.AgentArchivedError,
                _ => null,
            };
        }
    }
}