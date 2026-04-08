
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMCPServerURLDefinitionType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMCPServerURLDefinitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMCPServerURLDefinitionType value)
        {
            return value switch
            {
                BetaManagedAgentsMCPServerURLDefinitionType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMCPServerURLDefinitionType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaManagedAgentsMCPServerURLDefinitionType.Url,
                _ => null,
            };
        }
    }
}