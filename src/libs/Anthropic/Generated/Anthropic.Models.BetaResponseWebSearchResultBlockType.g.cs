
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_search_result
    /// </summary>
    public enum BetaResponseWebSearchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebSearchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchResultBlockType value)
        {
            return value switch
            {
                BetaResponseWebSearchResultBlockType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => BetaResponseWebSearchResultBlockType.WebSearchResult,
                _ => null,
            };
        }
    }
}