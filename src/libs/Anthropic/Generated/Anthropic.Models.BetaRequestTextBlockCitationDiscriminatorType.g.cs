
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextBlockCitationDiscriminatorType
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
    public static class BetaRequestTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                BetaRequestTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaRequestTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                BetaRequestTextBlockCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaRequestTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => BetaRequestTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaRequestTextBlockCitationDiscriminatorType.PageLocation,
                "web_search_result_location" => BetaRequestTextBlockCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}