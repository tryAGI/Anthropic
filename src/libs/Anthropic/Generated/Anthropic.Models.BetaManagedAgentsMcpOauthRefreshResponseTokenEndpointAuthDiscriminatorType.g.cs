
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType
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
    public static class BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType.ClientSecretBasic => "client_secret_basic",
                BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType.ClientSecretPost => "client_secret_post",
                BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType.ClientSecretBasic,
                "client_secret_post" => BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType.ClientSecretPost,
                "none" => BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType.None,
                _ => null,
            };
        }
    }
}