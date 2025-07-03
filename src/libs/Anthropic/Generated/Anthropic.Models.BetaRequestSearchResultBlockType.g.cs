
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestSearchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestSearchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestSearchResultBlockType value)
        {
            return value switch
            {
                BetaRequestSearchResultBlockType.SearchResult => "search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestSearchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "search_result" => BetaRequestSearchResultBlockType.SearchResult,
                _ => null,
            };
        }
    }
}