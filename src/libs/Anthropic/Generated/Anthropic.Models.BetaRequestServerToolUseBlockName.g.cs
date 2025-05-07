
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestServerToolUseBlockName
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestServerToolUseBlockName value)
        {
            return value switch
            {
                BetaRequestServerToolUseBlockName.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestServerToolUseBlockName? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => BetaRequestServerToolUseBlockName.WebSearch,
                _ => null,
            };
        }
    }
}