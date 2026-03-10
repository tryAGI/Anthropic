
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolSearchToolRegex20251119Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolRegex20251119,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolRegex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchToolRegex20251119TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchToolRegex20251119Type value)
        {
            return value switch
            {
                BetaToolSearchToolRegex20251119Type.ToolSearchToolRegex20251119 => "tool_search_tool_regex_20251119",
                BetaToolSearchToolRegex20251119Type.ToolSearchToolRegex => "tool_search_tool_regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchToolRegex20251119Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_regex_20251119" => BetaToolSearchToolRegex20251119Type.ToolSearchToolRegex20251119,
                "tool_search_tool_regex" => BetaToolSearchToolRegex20251119Type.ToolSearchToolRegex,
                _ => null,
            };
        }
    }
}