
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestToolRemovalBlockToolDiscriminatorType
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
    public static class BetaRequestToolRemovalBlockToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestToolRemovalBlockToolDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestToolRemovalBlockToolDiscriminatorType.McpToolReference => "mcp_tool_reference",
                BetaRequestToolRemovalBlockToolDiscriminatorType.McpToolsetReference => "mcp_toolset_reference",
                BetaRequestToolRemovalBlockToolDiscriminatorType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestToolRemovalBlockToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_reference" => BetaRequestToolRemovalBlockToolDiscriminatorType.McpToolReference,
                "mcp_toolset_reference" => BetaRequestToolRemovalBlockToolDiscriminatorType.McpToolsetReference,
                "tool_reference" => BetaRequestToolRemovalBlockToolDiscriminatorType.ToolReference,
                _ => null,
            };
        }
    }
}