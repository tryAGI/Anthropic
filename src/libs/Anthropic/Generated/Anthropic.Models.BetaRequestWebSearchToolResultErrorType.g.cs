
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebSearchToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestWebSearchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebSearchToolResultErrorType value)
        {
            return value switch
            {
                BetaRequestWebSearchToolResultErrorType.WebSearchToolResultError => "web_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebSearchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result_error" => BetaRequestWebSearchToolResultErrorType.WebSearchToolResultError,
                _ => null,
            };
        }
    }
}