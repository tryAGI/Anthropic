
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolSearchToolBM2520251119Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolBm2520251119,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolBm25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchToolBM2520251119TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchToolBM2520251119Type value)
        {
            return value switch
            {
                ToolSearchToolBM2520251119Type.ToolSearchToolBm2520251119 => "tool_search_tool_bm25_20251119",
                ToolSearchToolBM2520251119Type.ToolSearchToolBm25 => "tool_search_tool_bm25",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchToolBM2520251119Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_bm25_20251119" => ToolSearchToolBM2520251119Type.ToolSearchToolBm2520251119,
                "tool_search_tool_bm25" => ToolSearchToolBM2520251119Type.ToolSearchToolBm25,
                _ => null,
            };
        }
    }
}