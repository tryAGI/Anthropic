
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in `tool_use` blocks.
    /// </summary>
    public enum BetaWebFetchTool20250910Name
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebFetchTool20250910NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchTool20250910Name value)
        {
            return value switch
            {
                BetaWebFetchTool20250910Name.WebFetch => "web_fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchTool20250910Name? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch" => BetaWebFetchTool20250910Name.WebFetch,
                _ => null,
            };
        }
    }
}