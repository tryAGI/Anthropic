
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestWebSearchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestWebSearchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestWebSearchResultBlockType value)
        {
            return value switch
            {
                RequestWebSearchResultBlockType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestWebSearchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => RequestWebSearchResultBlockType.WebSearchResult,
                _ => null,
            };
        }
    }
}