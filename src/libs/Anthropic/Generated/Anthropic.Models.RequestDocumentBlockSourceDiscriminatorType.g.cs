
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestDocumentBlockSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestDocumentBlockSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDocumentBlockSourceDiscriminatorType value)
        {
            return value switch
            {
                RequestDocumentBlockSourceDiscriminatorType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDocumentBlockSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => RequestDocumentBlockSourceDiscriminatorType.Base64,
                _ => null,
            };
        }
    }
}