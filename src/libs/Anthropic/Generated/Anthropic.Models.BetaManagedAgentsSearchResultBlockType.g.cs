
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSearchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSearchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSearchResultBlockType value)
        {
            return value switch
            {
                BetaManagedAgentsSearchResultBlockType.SearchResult => "search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSearchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "search_result" => BetaManagedAgentsSearchResultBlockType.SearchResult,
                _ => null,
            };
        }
    }
}