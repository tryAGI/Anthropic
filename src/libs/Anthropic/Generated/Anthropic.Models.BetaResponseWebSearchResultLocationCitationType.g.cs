
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_search_result_location
    /// </summary>
    public enum BetaResponseWebSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchResultLocationCitationType value)
        {
            return value switch
            {
                BetaResponseWebSearchResultLocationCitationType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => BetaResponseWebSearchResultLocationCitationType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}