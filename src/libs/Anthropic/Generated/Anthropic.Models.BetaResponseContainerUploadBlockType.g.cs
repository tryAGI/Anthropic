
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: container_upload
    /// </summary>
    public enum BetaResponseContainerUploadBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseContainerUploadBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseContainerUploadBlockType value)
        {
            return value switch
            {
                BetaResponseContainerUploadBlockType.ContainerUpload => "container_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseContainerUploadBlockType? ToEnum(string value)
        {
            return value switch
            {
                "container_upload" => BetaResponseContainerUploadBlockType.ContainerUpload,
                _ => null,
            };
        }
    }
}