
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
        Omitted,
        /// <summary>
        /// 
        /// </summary>
        Summarized,
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
                ThinkingDisplayMode.Omitted => "omitted",
                ThinkingDisplayMode.Summarized => "summarized",
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
                "omitted" => ThinkingDisplayMode.Omitted,
                "summarized" => ThinkingDisplayMode.Summarized,
                _ => null,
            };
        }
    }
}