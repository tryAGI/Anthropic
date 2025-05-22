
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: mcp_tool_use
    /// </summary>
    public enum BetaResponseMCPToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        McpToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseMCPToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseMCPToolUseBlockType value)
        {
            return value switch
            {
                BetaResponseMCPToolUseBlockType.McpToolUse => "mcp_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseMCPToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_use" => BetaResponseMCPToolUseBlockType.McpToolUse,
                _ => null,
            };
        }
    }
}