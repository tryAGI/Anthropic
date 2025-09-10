
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: document
    /// </summary>
    public enum BetaResponseDocumentBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseDocumentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseDocumentBlockType value)
        {
            return value switch
            {
                BetaResponseDocumentBlockType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseDocumentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BetaResponseDocumentBlockType.Document,
                _ => null,
            };
        }
    }
}