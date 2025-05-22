
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Deleted object type.<br/>
    /// For file deletion, this is always `"file_deleted"`.<br/>
    /// Default Value: file_deleted
    /// </summary>
    public enum FileDeleteResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        FileDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileDeleteResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileDeleteResponseType value)
        {
            return value switch
            {
                FileDeleteResponseType.FileDeleted => "file_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileDeleteResponseType? ToEnum(string value)
        {
            return value switch
            {
                "file_deleted" => FileDeleteResponseType.FileDeleted,
                _ => null,
            };
        }
    }
}