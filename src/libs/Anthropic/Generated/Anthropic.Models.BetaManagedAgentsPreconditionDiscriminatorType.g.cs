
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsPreconditionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentSha256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsPreconditionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsPreconditionDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsPreconditionDiscriminatorType.ContentSha256 => "content_sha256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsPreconditionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "content_sha256" => BetaManagedAgentsPreconditionDiscriminatorType.ContentSha256,
                _ => null,
            };
        }
    }
}