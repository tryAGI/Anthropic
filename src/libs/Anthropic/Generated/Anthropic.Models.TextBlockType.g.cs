
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of content block.<br/>
    /// Default Value: text
    /// </summary>
    public enum TextBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextBlockType value)
        {
            return value switch
            {
                TextBlockType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextBlockType.Text,
                _ => null,
            };
        }
    }
}