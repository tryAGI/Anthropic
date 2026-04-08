
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMCPToolsetParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        McpToolset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMCPToolsetParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMCPToolsetParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsMCPToolsetParamsType.McpToolset => "mcp_toolset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMCPToolsetParamsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_toolset" => BetaManagedAgentsMCPToolsetParamsType.McpToolset,
                _ => null,
            };
        }
    }
}