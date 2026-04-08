
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMCPServerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMCPServerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMCPServerDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMCPServerDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMCPServerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaManagedAgentsMCPServerDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}