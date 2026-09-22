
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseToolRemovalBlockToolDiscriminatorType
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
    public static class BetaResponseToolRemovalBlockToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseToolRemovalBlockToolDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseToolRemovalBlockToolDiscriminatorType.McpToolReference => "mcp_tool_reference",
                BetaResponseToolRemovalBlockToolDiscriminatorType.McpToolsetReference => "mcp_toolset_reference",
                BetaResponseToolRemovalBlockToolDiscriminatorType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseToolRemovalBlockToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_reference" => BetaResponseToolRemovalBlockToolDiscriminatorType.McpToolReference,
                "mcp_toolset_reference" => BetaResponseToolRemovalBlockToolDiscriminatorType.McpToolsetReference,
                "tool_reference" => BetaResponseToolRemovalBlockToolDiscriminatorType.ToolReference,
                _ => null,
            };
        }
    }
}