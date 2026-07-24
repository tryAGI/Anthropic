
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Limited,
        /// <summary>
        /// 
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCredentialNetworkingParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType.Limited => "limited",
                BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType.Limited,
                "unrestricted" => BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType.Unrestricted,
                _ => null,
            };
        }
    }
}