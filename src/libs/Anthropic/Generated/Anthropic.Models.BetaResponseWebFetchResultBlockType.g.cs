
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_fetch_result
    /// </summary>
    public enum BetaResponseWebFetchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebFetchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebFetchResultBlockType value)
        {
            return value switch
            {
                BetaResponseWebFetchResultBlockType.WebFetchResult => "web_fetch_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebFetchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_result" => BetaResponseWebFetchResultBlockType.WebFetchResult,
                _ => null,
            };
        }
    }
}