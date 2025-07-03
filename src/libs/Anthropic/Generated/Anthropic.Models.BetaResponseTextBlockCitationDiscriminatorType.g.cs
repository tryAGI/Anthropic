
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseTextBlockCitationDiscriminatorType
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
    public static class BetaResponseTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                BetaResponseTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaResponseTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                BetaResponseTextBlockCitationDiscriminatorType.SearchResultLocation => "search_result_location",
                BetaResponseTextBlockCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaResponseTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => BetaResponseTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaResponseTextBlockCitationDiscriminatorType.PageLocation,
                "search_result_location" => BetaResponseTextBlockCitationDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => BetaResponseTextBlockCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}