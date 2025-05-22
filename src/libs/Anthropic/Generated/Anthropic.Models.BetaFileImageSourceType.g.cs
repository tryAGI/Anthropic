
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFileImageSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileImageSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileImageSourceType value)
        {
            return value switch
            {
                BetaFileImageSourceType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileImageSourceType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaFileImageSourceType.File,
                _ => null,
            };
        }
    }
}