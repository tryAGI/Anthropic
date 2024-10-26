
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of content block.<br/>
    /// Default Value: image
    /// </summary>
    public enum ImageBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBlockType value)
        {
            return value switch
            {
                ImageBlockType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBlockType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ImageBlockType.Image,
                _ => null,
            };
        }
    }
}