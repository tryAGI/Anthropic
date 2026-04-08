
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsTokenEndpointAuthBasicParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretBasic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsTokenEndpointAuthBasicParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTokenEndpointAuthBasicParamType value)
        {
            return value switch
            {
                BetaManagedAgentsTokenEndpointAuthBasicParamType.ClientSecretBasic => "client_secret_basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTokenEndpointAuthBasicParamType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => BetaManagedAgentsTokenEndpointAuthBasicParamType.ClientSecretBasic,
                _ => null,
            };
        }
    }
}