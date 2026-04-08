
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsURLDocumentSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsURLDocumentSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsURLDocumentSourceType value)
        {
            return value switch
            {
                BetaManagedAgentsURLDocumentSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsURLDocumentSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaManagedAgentsURLDocumentSourceType.Url,
                _ => null,
            };
        }
    }
}