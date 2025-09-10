
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_fetch_tool_result_error
    /// </summary>
    public enum BetaResponseWebFetchToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebFetchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebFetchToolResultErrorType value)
        {
            return value switch
            {
                BetaResponseWebFetchToolResultErrorType.WebFetchToolResultError => "web_fetch_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebFetchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result_error" => BetaResponseWebFetchToolResultErrorType.WebFetchToolResultError,
                _ => null,
            };
        }
    }
}