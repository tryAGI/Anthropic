
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMCPToolsetType
    {
        /// <summary>
        /// 
        /// </summary>
        McpToolset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMCPToolsetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMCPToolsetType value)
        {
            return value switch
            {
                BetaManagedAgentsMCPToolsetType.McpToolset => "mcp_toolset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMCPToolsetType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_toolset" => BetaManagedAgentsMCPToolsetType.McpToolset,
                _ => null,
            };
        }
    }
}