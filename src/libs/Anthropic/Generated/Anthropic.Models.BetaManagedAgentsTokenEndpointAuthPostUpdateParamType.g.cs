
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsTokenEndpointAuthPostUpdateParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsTokenEndpointAuthPostUpdateParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTokenEndpointAuthPostUpdateParamType value)
        {
            return value switch
            {
                BetaManagedAgentsTokenEndpointAuthPostUpdateParamType.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTokenEndpointAuthPostUpdateParamType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_post" => BetaManagedAgentsTokenEndpointAuthPostUpdateParamType.ClientSecretPost,
                _ => null,
            };
        }
    }
}