
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolSearchToolBM2520251119Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolBm25,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolBm2520251119,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchToolBM2520251119TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchToolBM2520251119Type value)
        {
            return value switch
            {
                BetaToolSearchToolBM2520251119Type.ToolSearchToolBm25 => "tool_search_tool_bm25",
                BetaToolSearchToolBM2520251119Type.ToolSearchToolBm2520251119 => "tool_search_tool_bm25_20251119",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchToolBM2520251119Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_bm25" => BetaToolSearchToolBM2520251119Type.ToolSearchToolBm25,
                "tool_search_tool_bm25_20251119" => BetaToolSearchToolBM2520251119Type.ToolSearchToolBm2520251119,
                _ => null,
            };
        }
    }
}