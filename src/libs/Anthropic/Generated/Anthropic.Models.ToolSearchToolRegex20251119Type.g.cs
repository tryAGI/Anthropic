
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolSearchToolRegex20251119Type
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
    public static class ToolSearchToolRegex20251119TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchToolRegex20251119Type value)
        {
            return value switch
            {
                ToolSearchToolRegex20251119Type.ToolSearchToolRegex20251119 => "tool_search_tool_regex_20251119",
                ToolSearchToolRegex20251119Type.ToolSearchToolRegex => "tool_search_tool_regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchToolRegex20251119Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_regex_20251119" => ToolSearchToolRegex20251119Type.ToolSearchToolRegex20251119,
                "tool_search_tool_regex" => ToolSearchToolRegex20251119Type.ToolSearchToolRegex,
                _ => null,
            };
        }
    }
}