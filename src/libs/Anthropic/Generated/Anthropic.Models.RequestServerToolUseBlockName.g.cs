
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestServerToolUseBlockName
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestServerToolUseBlockName value)
        {
            return value switch
            {
                RequestServerToolUseBlockName.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestServerToolUseBlockName? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => RequestServerToolUseBlockName.WebSearch,
                _ => null,
            };
        }
    }
}