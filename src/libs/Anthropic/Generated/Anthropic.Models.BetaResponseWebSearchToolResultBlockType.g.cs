
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_search_tool_result
    /// </summary>
    public enum BetaResponseWebSearchToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebSearchToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchToolResultBlockType value)
        {
            return value switch
            {
                BetaResponseWebSearchToolResultBlockType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result" => BetaResponseWebSearchToolResultBlockType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}