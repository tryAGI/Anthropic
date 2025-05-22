
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestContainerUploadBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestContainerUploadBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestContainerUploadBlockType value)
        {
            return value switch
            {
                BetaRequestContainerUploadBlockType.ContainerUpload => "container_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestContainerUploadBlockType? ToEnum(string value)
        {
            return value switch
            {
                "container_upload" => BetaRequestContainerUploadBlockType.ContainerUpload,
                _ => null,
            };
        }
    }
}