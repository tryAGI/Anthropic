
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: search_result_location
    /// </summary>
    public enum ResponseSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSearchResultLocationCitationType value)
        {
            return value switch
            {
                ResponseSearchResultLocationCitationType.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => ResponseSearchResultLocationCitationType.SearchResultLocation,
                _ => null,
            };
        }
    }
}