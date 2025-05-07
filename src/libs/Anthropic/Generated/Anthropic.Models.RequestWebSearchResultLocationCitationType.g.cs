
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestWebSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestWebSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestWebSearchResultLocationCitationType value)
        {
            return value switch
            {
                RequestWebSearchResultLocationCitationType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestWebSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => RequestWebSearchResultLocationCitationType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}