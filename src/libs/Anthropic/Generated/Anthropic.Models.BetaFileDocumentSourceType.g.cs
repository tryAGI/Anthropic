
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFileDocumentSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileDocumentSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileDocumentSourceType value)
        {
            return value switch
            {
                BetaFileDocumentSourceType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileDocumentSourceType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaFileDocumentSourceType.File,
                _ => null,
            };
        }
    }
}