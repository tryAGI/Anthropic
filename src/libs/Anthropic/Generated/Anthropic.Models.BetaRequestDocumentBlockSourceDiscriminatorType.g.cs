
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestDocumentBlockSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Content,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestDocumentBlockSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestDocumentBlockSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestDocumentBlockSourceDiscriminatorType.Base64 => "base64",
                BetaRequestDocumentBlockSourceDiscriminatorType.Content => "content",
                BetaRequestDocumentBlockSourceDiscriminatorType.File => "file",
                BetaRequestDocumentBlockSourceDiscriminatorType.Text => "text",
                BetaRequestDocumentBlockSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestDocumentBlockSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaRequestDocumentBlockSourceDiscriminatorType.Base64,
                "content" => BetaRequestDocumentBlockSourceDiscriminatorType.Content,
                "file" => BetaRequestDocumentBlockSourceDiscriminatorType.File,
                "text" => BetaRequestDocumentBlockSourceDiscriminatorType.Text,
                "url" => BetaRequestDocumentBlockSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}