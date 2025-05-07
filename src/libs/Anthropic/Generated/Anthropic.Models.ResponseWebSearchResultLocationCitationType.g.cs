
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_search_result_location
    /// </summary>
    public enum ResponseWebSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseWebSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebSearchResultLocationCitationType value)
        {
            return value switch
            {
                ResponseWebSearchResultLocationCitationType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => ResponseWebSearchResultLocationCitationType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}