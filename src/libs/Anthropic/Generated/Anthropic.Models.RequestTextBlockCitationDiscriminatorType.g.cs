
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTextBlockCitationDiscriminatorType
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
    public static class RequestTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                RequestTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                RequestTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                RequestTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                RequestTextBlockCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => RequestTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => RequestTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => RequestTextBlockCitationDiscriminatorType.PageLocation,
                "web_search_result_location" => RequestTextBlockCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}