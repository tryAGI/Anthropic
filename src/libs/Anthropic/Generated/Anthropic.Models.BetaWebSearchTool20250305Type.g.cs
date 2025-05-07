
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebSearchTool20250305Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch20250305,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchTool20250305TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchTool20250305Type value)
        {
            return value switch
            {
                BetaWebSearchTool20250305Type.WebSearch20250305 => "web_search_20250305",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchTool20250305Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_20250305" => BetaWebSearchTool20250305Type.WebSearch20250305,
                _ => null,
            };
        }
    }
}