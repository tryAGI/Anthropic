
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsLimitedCredentialNetworkingParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Limited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsLimitedCredentialNetworkingParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsLimitedCredentialNetworkingParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsLimitedCredentialNetworkingParamsType.Limited => "limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsLimitedCredentialNetworkingParamsType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => BetaManagedAgentsLimitedCredentialNetworkingParamsType.Limited,
                _ => null,
            };
        }
    }
}