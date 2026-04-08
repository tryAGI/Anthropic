
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsURLMCPServerParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsURLMCPServerParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsURLMCPServerParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsURLMCPServerParamsType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsURLMCPServerParamsType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaManagedAgentsURLMCPServerParamsType.Url,
                _ => null,
            };
        }
    }
}