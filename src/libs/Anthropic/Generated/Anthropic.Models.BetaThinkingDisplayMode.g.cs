
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaThinkingDisplayMode
    {
        /// <summary>
        /// 
        /// </summary>
        Omitted,
        /// <summary>
        /// 
        /// </summary>
        Summarized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThinkingDisplayModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingDisplayMode value)
        {
            return value switch
            {
                BetaThinkingDisplayMode.Omitted => "omitted",
                BetaThinkingDisplayMode.Summarized => "summarized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingDisplayMode? ToEnum(string value)
        {
            return value switch
            {
                "omitted" => BetaThinkingDisplayMode.Omitted,
                "summarized" => BetaThinkingDisplayMode.Summarized,
                _ => null,
            };
        }
    }
}