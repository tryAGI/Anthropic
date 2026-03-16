
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
        Summarized,
        /// <summary>
        /// 
        /// </summary>
        Omitted,
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
                BetaThinkingDisplayMode.Summarized => "summarized",
                BetaThinkingDisplayMode.Omitted => "omitted",
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
                "summarized" => BetaThinkingDisplayMode.Summarized,
                "omitted" => BetaThinkingDisplayMode.Omitted,
                _ => null,
            };
        }
    }
}