
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTextBlockCitationDiscriminatorType
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
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                ResponseTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                ResponseTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                ResponseTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                ResponseTextBlockCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => ResponseTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => ResponseTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => ResponseTextBlockCitationDiscriminatorType.PageLocation,
                "web_search_result_location" => ResponseTextBlockCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}