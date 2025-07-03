
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: search_result_location
    /// </summary>
    public enum BetaResponseSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSearchResultLocationCitationType value)
        {
            return value switch
            {
                BetaResponseSearchResultLocationCitationType.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => BetaResponseSearchResultLocationCitationType.SearchResultLocation,
                _ => null,
            };
        }
    }
}