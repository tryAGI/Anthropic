
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpOauthAuthResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        McpOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpOauthAuthResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpOauthAuthResponseType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpOauthAuthResponseType.McpOauth => "mcp_oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpOauthAuthResponseType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => BetaManagedAgentsMcpOauthAuthResponseType.McpOauth,
                _ => null,
            };
        }
    }
}