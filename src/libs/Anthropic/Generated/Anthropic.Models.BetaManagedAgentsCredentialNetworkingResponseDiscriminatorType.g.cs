
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType
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
    public static class BetaManagedAgentsCredentialNetworkingResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType.Limited => "limited",
                BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType.Limited,
                "unrestricted" => BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType.Unrestricted,
                _ => null,
            };
        }
    }
}