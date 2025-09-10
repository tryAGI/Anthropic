
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebFetchTool20250910Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetch20250910,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebFetchTool20250910TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchTool20250910Type value)
        {
            return value switch
            {
                BetaWebFetchTool20250910Type.WebFetch20250910 => "web_fetch_20250910",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchTool20250910Type? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_20250910" => BetaWebFetchTool20250910Type.WebFetch20250910,
                _ => null,
            };
        }
    }
}