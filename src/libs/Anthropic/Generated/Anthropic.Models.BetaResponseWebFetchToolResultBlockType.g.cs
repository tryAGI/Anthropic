
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: web_fetch_tool_result
    /// </summary>
    public enum BetaResponseWebFetchToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebFetchToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebFetchToolResultBlockType value)
        {
            return value switch
            {
                BetaResponseWebFetchToolResultBlockType.WebFetchToolResult => "web_fetch_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebFetchToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result" => BetaResponseWebFetchToolResultBlockType.WebFetchToolResult,
                _ => null,
            };
        }
    }
}