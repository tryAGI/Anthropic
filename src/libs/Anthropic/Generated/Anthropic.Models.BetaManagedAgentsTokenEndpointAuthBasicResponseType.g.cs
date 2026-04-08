
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsTokenEndpointAuthBasicResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretBasic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsTokenEndpointAuthBasicResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTokenEndpointAuthBasicResponseType value)
        {
            return value switch
            {
                BetaManagedAgentsTokenEndpointAuthBasicResponseType.ClientSecretBasic => "client_secret_basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTokenEndpointAuthBasicResponseType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => BetaManagedAgentsTokenEndpointAuthBasicResponseType.ClientSecretBasic,
                _ => null,
            };
        }
    }
}