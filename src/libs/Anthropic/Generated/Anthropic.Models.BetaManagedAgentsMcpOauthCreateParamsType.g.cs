
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpOauthCreateParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        McpOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpOauthCreateParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpOauthCreateParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpOauthCreateParamsType.McpOauth => "mcp_oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpOauthCreateParamsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => BetaManagedAgentsMcpOauthCreateParamsType.McpOauth,
                _ => null,
            };
        }
    }
}