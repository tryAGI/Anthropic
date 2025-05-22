
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Object type.<br/>
    /// For files, this is always `"file"`.
    /// </summary>
    public enum FileMetadataSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileMetadataSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileMetadataSchemaType value)
        {
            return value switch
            {
                FileMetadataSchemaType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileMetadataSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "file" => FileMetadataSchemaType.File,
                _ => null,
            };
        }
    }
}