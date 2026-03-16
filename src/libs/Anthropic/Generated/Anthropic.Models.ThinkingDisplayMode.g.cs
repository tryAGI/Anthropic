
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThinkingDisplayMode
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
    public static class ThinkingDisplayModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingDisplayMode value)
        {
            return value switch
            {
                ThinkingDisplayMode.Summarized => "summarized",
                ThinkingDisplayMode.Omitted => "omitted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingDisplayMode? ToEnum(string value)
        {
            return value switch
            {
                "summarized" => ThinkingDisplayMode.Summarized,
                "omitted" => ThinkingDisplayMode.Omitted,
                _ => null,
            };
        }
    }
}