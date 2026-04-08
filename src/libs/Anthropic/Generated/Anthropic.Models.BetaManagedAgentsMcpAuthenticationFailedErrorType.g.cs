
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpAuthenticationFailedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        McpAuthenticationFailedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpAuthenticationFailedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpAuthenticationFailedErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpAuthenticationFailedErrorType.McpAuthenticationFailedError => "mcp_authentication_failed_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpAuthenticationFailedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_authentication_failed_error" => BetaManagedAgentsMcpAuthenticationFailedErrorType.McpAuthenticationFailedError,
                _ => null,
            };
        }
    }
}