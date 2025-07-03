
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCitationsDeltaCitationDiscriminatorType
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
    public static class BetaCitationsDeltaCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCitationsDeltaCitationDiscriminatorType value)
        {
            return value switch
            {
                BetaCitationsDeltaCitationDiscriminatorType.CharLocation => "char_location",
                BetaCitationsDeltaCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaCitationsDeltaCitationDiscriminatorType.PageLocation => "page_location",
                BetaCitationsDeltaCitationDiscriminatorType.SearchResultLocation => "search_result_location",
                BetaCitationsDeltaCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCitationsDeltaCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaCitationsDeltaCitationDiscriminatorType.CharLocation,
                "content_block_location" => BetaCitationsDeltaCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaCitationsDeltaCitationDiscriminatorType.PageLocation,
                "search_result_location" => BetaCitationsDeltaCitationDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => BetaCitationsDeltaCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}