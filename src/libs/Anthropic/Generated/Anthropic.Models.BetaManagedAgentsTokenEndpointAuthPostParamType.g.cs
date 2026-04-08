
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsTokenEndpointAuthPostParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsTokenEndpointAuthPostParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTokenEndpointAuthPostParamType value)
        {
            return value switch
            {
                BetaManagedAgentsTokenEndpointAuthPostParamType.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTokenEndpointAuthPostParamType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_post" => BetaManagedAgentsTokenEndpointAuthPostParamType.ClientSecretPost,
                _ => null,
            };
        }
    }
}