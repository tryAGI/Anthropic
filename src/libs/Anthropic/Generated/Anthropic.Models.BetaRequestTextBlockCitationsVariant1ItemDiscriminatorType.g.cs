
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType
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
    public static class BetaRequestTextBlockCitationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation => "char_location",
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation => "page_location",
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation => "search_result_location",
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation,
                "content_block_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation,
                "search_result_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}