
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestMCPToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        McpToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestMCPToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestMCPToolResultBlockType value)
        {
            return value switch
            {
                BetaRequestMCPToolResultBlockType.McpToolResult => "mcp_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestMCPToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_result" => BetaRequestMCPToolResultBlockType.McpToolResult,
                _ => null,
            };
        }
    }
}