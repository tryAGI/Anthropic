
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsContentSha256PreconditionType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentSha256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsContentSha256PreconditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsContentSha256PreconditionType value)
        {
            return value switch
            {
                BetaManagedAgentsContentSha256PreconditionType.ContentSha256 => "content_sha256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsContentSha256PreconditionType? ToEnum(string value)
        {
            return value switch
            {
                "content_sha256" => BetaManagedAgentsContentSha256PreconditionType.ContentSha256,
                _ => null,
            };
        }
    }
}