
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialCreateAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        McpOauth,
        /// <summary>
        /// 
        /// </summary>
        StaticBearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCredentialCreateAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialCreateAuthDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialCreateAuthDiscriminatorType.McpOauth => "mcp_oauth",
                BetaManagedAgentsCredentialCreateAuthDiscriminatorType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialCreateAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => BetaManagedAgentsCredentialCreateAuthDiscriminatorType.McpOauth,
                "static_bearer" => BetaManagedAgentsCredentialCreateAuthDiscriminatorType.StaticBearer,
                _ => null,
            };
        }
    }
}