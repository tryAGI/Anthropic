
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpOauthUpdateParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        McpOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpOauthUpdateParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpOauthUpdateParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpOauthUpdateParamsType.McpOauth => "mcp_oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpOauthUpdateParamsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => BetaManagedAgentsMcpOauthUpdateParamsType.McpOauth,
                _ => null,
            };
        }
    }
}