
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: mcp_tool_result
    /// </summary>
    public enum BetaResponseMCPToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        McpToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseMCPToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseMCPToolResultBlockType value)
        {
            return value switch
            {
                BetaResponseMCPToolResultBlockType.McpToolResult => "mcp_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseMCPToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_result" => BetaResponseMCPToolResultBlockType.McpToolResult,
                _ => null,
            };
        }
    }
}