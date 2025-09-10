
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebFetchResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestWebFetchResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebFetchResultBlockType value)
        {
            return value switch
            {
                BetaRequestWebFetchResultBlockType.WebFetchResult => "web_fetch_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebFetchResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_result" => BetaRequestWebFetchResultBlockType.WebFetchResult,
                _ => null,
            };
        }
    }
}