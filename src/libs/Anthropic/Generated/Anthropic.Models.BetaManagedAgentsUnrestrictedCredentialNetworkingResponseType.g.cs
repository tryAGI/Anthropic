
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUnrestrictedCredentialNetworkingResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType value)
        {
            return value switch
            {
                BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType? ToEnum(string value)
        {
            return value switch
            {
                "unrestricted" => BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType.Unrestricted,
                _ => null,
            };
        }
    }
}