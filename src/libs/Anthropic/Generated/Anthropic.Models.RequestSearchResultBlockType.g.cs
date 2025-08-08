
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestSearchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestSearchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestSearchResultBlockType value)
        {
            return value switch
            {
                RequestSearchResultBlockType.SearchResult => "search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestSearchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "search_result" => RequestSearchResultBlockType.SearchResult,
                _ => null,
            };
        }
    }
}