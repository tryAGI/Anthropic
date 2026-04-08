
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpConnectionFailedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        McpConnectionFailedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpConnectionFailedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpConnectionFailedErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpConnectionFailedErrorType.McpConnectionFailedError => "mcp_connection_failed_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpConnectionFailedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_connection_failed_error" => BetaManagedAgentsMcpConnectionFailedErrorType.McpConnectionFailedError,
                _ => null,
            };
        }
    }
}