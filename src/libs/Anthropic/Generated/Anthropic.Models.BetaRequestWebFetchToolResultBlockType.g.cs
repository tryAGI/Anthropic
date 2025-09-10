
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebFetchToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestWebFetchToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebFetchToolResultBlockType value)
        {
            return value switch
            {
                BetaRequestWebFetchToolResultBlockType.WebFetchToolResult => "web_fetch_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebFetchToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result" => BetaRequestWebFetchToolResultBlockType.WebFetchToolResult,
                _ => null,
            };
        }
    }
}