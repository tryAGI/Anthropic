
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTextEditor20250429Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor20250429,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextEditor20250429TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20250429Type value)
        {
            return value switch
            {
                BetaTextEditor20250429Type.TextEditor20250429 => "text_editor_20250429",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20250429Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250429" => BetaTextEditor20250429Type.TextEditor20250429,
                _ => null,
            };
        }
    }
}