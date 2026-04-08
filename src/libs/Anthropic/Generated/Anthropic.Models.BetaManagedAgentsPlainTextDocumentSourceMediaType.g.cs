
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// MIME type of the text content. Must be "text/plain".
    /// </summary>
    public enum BetaManagedAgentsPlainTextDocumentSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsPlainTextDocumentSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsPlainTextDocumentSourceMediaType value)
        {
            return value switch
            {
                BetaManagedAgentsPlainTextDocumentSourceMediaType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsPlainTextDocumentSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "text/plain" => BetaManagedAgentsPlainTextDocumentSourceMediaType.TextPlain,
                _ => null,
            };
        }
    }
}