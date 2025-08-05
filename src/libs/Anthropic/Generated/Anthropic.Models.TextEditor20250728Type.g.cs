
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEditor20250728Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor20250728,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditor20250728TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditor20250728Type value)
        {
            return value switch
            {
                TextEditor20250728Type.TextEditor20250728 => "text_editor_20250728",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditor20250728Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250728" => TextEditor20250728Type.TextEditor20250728,
                _ => null,
            };
        }
    }
}