
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebSearchResultLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestWebSearchResultLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebSearchResultLocationCitationType value)
        {
            return value switch
            {
                BetaRequestWebSearchResultLocationCitationType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebSearchResultLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => BetaRequestWebSearchResultLocationCitationType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}