
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextBlockCitationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation => "char_location",
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation => "page_location",
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation => "search_result_location",
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation,
                "content_block_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation,
                "search_result_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}