
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Object type.<br/>
    /// For files, this is always `"file"`.
    /// </summary>
    public enum BetaFileMetadataSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileMetadataSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileMetadataSchemaType value)
        {
            return value switch
            {
                BetaFileMetadataSchemaType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileMetadataSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaFileMetadataSchemaType.File,
                _ => null,
            };
        }
    }
}