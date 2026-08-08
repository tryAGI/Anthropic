
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpEgressBlockedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        McpEgressBlockedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpEgressBlockedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpEgressBlockedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpEgressBlockedRunErrorType.McpEgressBlockedError => "mcp_egress_blocked_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpEgressBlockedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_egress_blocked_error" => BetaManagedAgentsMcpEgressBlockedRunErrorType.McpEgressBlockedError,
                _ => null,
            };
        }
    }
}