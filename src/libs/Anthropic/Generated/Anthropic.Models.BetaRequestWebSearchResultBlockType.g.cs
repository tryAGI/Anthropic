
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebSearchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestWebSearchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebSearchResultBlockType value)
        {
            return value switch
            {
                BetaRequestWebSearchResultBlockType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebSearchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => BetaRequestWebSearchResultBlockType.WebSearchResult,
                _ => null,
            };
        }
    }
}