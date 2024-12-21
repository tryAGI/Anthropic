
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
                _ => null,
            };
        }
    }
}