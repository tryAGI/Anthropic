
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEditor20250429Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor20250429,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditor20250429TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditor20250429Type value)
        {
            return value switch
            {
                TextEditor20250429Type.TextEditor20250429 => "text_editor_20250429",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditor20250429Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250429" => TextEditor20250429Type.TextEditor20250429,
                _ => null,
            };
        }
    }
}