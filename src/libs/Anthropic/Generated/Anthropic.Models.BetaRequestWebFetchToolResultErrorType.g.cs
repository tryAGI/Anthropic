
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebFetchToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestWebFetchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebFetchToolResultErrorType value)
        {
            return value switch
            {
                BetaRequestWebFetchToolResultErrorType.WebFetchToolResultError => "web_fetch_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebFetchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result_error" => BetaRequestWebFetchToolResultErrorType.WebFetchToolResultError,
                _ => null,
            };
        }
    }
}