
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_search_result
    /// </summary>
    public enum ResponseWebSearchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseWebSearchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebSearchResultBlockType value)
        {
            return value switch
            {
                ResponseWebSearchResultBlockType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebSearchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => ResponseWebSearchResultBlockType.WebSearchResult,
                _ => null,
            };
        }
    }
}