
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        /// 
        /// </summary>
        ClientSecretPost,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType.ClientSecretBasic => "client_secret_basic",
                BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType.ClientSecretPost => "client_secret_post",
                BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType.ClientSecretBasic,
                "client_secret_post" => BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType.ClientSecretPost,
                "none" => BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType.None,
                _ => null,
            };
        }
    }
}