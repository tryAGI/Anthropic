
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUnrestrictedCredentialNetworkingParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUnrestrictedCredentialNetworkingParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUnrestrictedCredentialNetworkingParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsUnrestrictedCredentialNetworkingParamsType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUnrestrictedCredentialNetworkingParamsType? ToEnum(string value)
        {
            return value switch
            {
                "unrestricted" => BetaManagedAgentsUnrestrictedCredentialNetworkingParamsType.Unrestricted,
                _ => null,
            };
        }
    }
}