
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebSearchToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestWebSearchToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebSearchToolResultBlockType value)
        {
            return value switch
            {
                BetaRequestWebSearchToolResultBlockType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebSearchToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result" => BetaRequestWebSearchToolResultBlockType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}