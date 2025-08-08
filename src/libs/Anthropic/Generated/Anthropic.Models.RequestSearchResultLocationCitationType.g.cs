
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestSearchResultLocationCitationType value)
        {
            return value switch
            {
                RequestSearchResultLocationCitationType.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => RequestSearchResultLocationCitationType.SearchResultLocation,
                _ => null,
            };
        }
    }
}