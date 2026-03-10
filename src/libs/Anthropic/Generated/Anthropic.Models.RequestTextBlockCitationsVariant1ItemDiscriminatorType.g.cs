
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTextBlockCitationsVariant1ItemDiscriminatorType
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
    public static class RequestTextBlockCitationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTextBlockCitationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                RequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation => "char_location",
                RequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation => "content_block_location",
                RequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation => "page_location",
                RequestTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation => "search_result_location",
                RequestTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTextBlockCitationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => RequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation,
                "content_block_location" => RequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation,
                "page_location" => RequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation,
                "search_result_location" => RequestTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => RequestTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}