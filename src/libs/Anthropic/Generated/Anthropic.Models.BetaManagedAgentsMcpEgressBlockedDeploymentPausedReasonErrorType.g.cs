
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        McpEgressBlockedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType.McpEgressBlockedError => "mcp_egress_blocked_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_egress_blocked_error" => BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType.McpEgressBlockedError,
                _ => null,
            };
        }
    }
}