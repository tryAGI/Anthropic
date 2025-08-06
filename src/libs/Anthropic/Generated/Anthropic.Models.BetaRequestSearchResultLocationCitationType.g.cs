
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestSearchResultLocationCitationType value)
        {
            return value switch
            {
                BetaRequestSearchResultLocationCitationType.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => BetaRequestSearchResultLocationCitationType.SearchResultLocation,
                _ => null,
            };
        }
    }
}