
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestWebSearchToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestWebSearchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestWebSearchToolResultErrorType value)
        {
            return value switch
            {
                RequestWebSearchToolResultErrorType.WebSearchToolResultError => "web_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestWebSearchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result_error" => RequestWebSearchToolResultErrorType.WebSearchToolResultError,
                _ => null,
            };
        }
    }
}