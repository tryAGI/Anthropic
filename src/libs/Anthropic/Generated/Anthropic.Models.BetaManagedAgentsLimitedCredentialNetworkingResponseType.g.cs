
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsLimitedCredentialNetworkingResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Limited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsLimitedCredentialNetworkingResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsLimitedCredentialNetworkingResponseType value)
        {
            return value switch
            {
                BetaManagedAgentsLimitedCredentialNetworkingResponseType.Limited => "limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsLimitedCredentialNetworkingResponseType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => BetaManagedAgentsLimitedCredentialNetworkingResponseType.Limited,
                _ => null,
            };
        }
    }
}