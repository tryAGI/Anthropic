
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestToolAdditionBlockToolDiscriminatorType
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
        ToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestToolAdditionBlockToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestToolAdditionBlockToolDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestToolAdditionBlockToolDiscriminatorType.McpToolReference => "mcp_tool_reference",
                BetaRequestToolAdditionBlockToolDiscriminatorType.McpToolsetReference => "mcp_toolset_reference",
                BetaRequestToolAdditionBlockToolDiscriminatorType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestToolAdditionBlockToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_reference" => BetaRequestToolAdditionBlockToolDiscriminatorType.McpToolReference,
                "mcp_toolset_reference" => BetaRequestToolAdditionBlockToolDiscriminatorType.McpToolsetReference,
                "tool_reference" => BetaRequestToolAdditionBlockToolDiscriminatorType.ToolReference,
                _ => null,
            };
        }
    }
}