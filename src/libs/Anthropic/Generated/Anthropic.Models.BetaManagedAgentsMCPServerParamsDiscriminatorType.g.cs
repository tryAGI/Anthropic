
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMCPServerParamsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMCPServerParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMCPServerParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMCPServerParamsDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMCPServerParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaManagedAgentsMCPServerParamsDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}