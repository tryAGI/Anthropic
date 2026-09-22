
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseToolAdditionBlockToolDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        McpToolReference,
        /// <summary>
        ///
        /// </summary>
        McpToolsetReference,
        /// <summary>
        ///
        /// </summary>
        ToolDefinition,
        /// <summary>
        ///
        /// </summary>
        ToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseToolAdditionBlockToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseToolAdditionBlockToolDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseToolAdditionBlockToolDiscriminatorType.McpToolReference => "mcp_tool_reference",
                BetaResponseToolAdditionBlockToolDiscriminatorType.McpToolsetReference => "mcp_toolset_reference",
                BetaResponseToolAdditionBlockToolDiscriminatorType.ToolDefinition => "tool_definition",
                BetaResponseToolAdditionBlockToolDiscriminatorType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseToolAdditionBlockToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_reference" => BetaResponseToolAdditionBlockToolDiscriminatorType.McpToolReference,
                "mcp_toolset_reference" => BetaResponseToolAdditionBlockToolDiscriminatorType.McpToolsetReference,
                "tool_definition" => BetaResponseToolAdditionBlockToolDiscriminatorType.ToolDefinition,
                "tool_reference" => BetaResponseToolAdditionBlockToolDiscriminatorType.ToolReference,
                _ => null,
            };
        }
    }
}