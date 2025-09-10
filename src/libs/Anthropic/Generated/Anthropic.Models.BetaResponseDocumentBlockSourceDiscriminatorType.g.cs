
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseDocumentBlockSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseDocumentBlockSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseDocumentBlockSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseDocumentBlockSourceDiscriminatorType.Base64 => "base64",
                BetaResponseDocumentBlockSourceDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseDocumentBlockSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaResponseDocumentBlockSourceDiscriminatorType.Base64,
                "text" => BetaResponseDocumentBlockSourceDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}