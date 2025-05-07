
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_search_tool_result_error
    /// </summary>
    public enum BetaResponseWebSearchToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebSearchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchToolResultErrorType value)
        {
            return value switch
            {
                BetaResponseWebSearchToolResultErrorType.WebSearchToolResultError => "web_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result_error" => BetaResponseWebSearchToolResultErrorType.WebSearchToolResultError,
                _ => null,
            };
        }
    }
}