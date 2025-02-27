
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTextEditor20250124Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextEditor20250124TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20250124Type value)
        {
            return value switch
            {
                BetaTextEditor20250124Type.TextEditor20250124 => "text_editor_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20250124Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250124" => BetaTextEditor20250124Type.TextEditor20250124,
                _ => null,
            };
        }
    }
}