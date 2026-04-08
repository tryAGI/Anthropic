
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsBase64DocumentSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsBase64DocumentSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsBase64DocumentSourceType value)
        {
            return value switch
            {
                BetaManagedAgentsBase64DocumentSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsBase64DocumentSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaManagedAgentsBase64DocumentSourceType.Base64,
                _ => null,
            };
        }
    }
}