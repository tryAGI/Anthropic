
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialAuthDiscriminatorType
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
    public static class BetaManagedAgentsCredentialAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialAuthDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialAuthDiscriminatorType.McpOauth => "mcp_oauth",
                BetaManagedAgentsCredentialAuthDiscriminatorType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => BetaManagedAgentsCredentialAuthDiscriminatorType.McpOauth,
                "static_bearer" => BetaManagedAgentsCredentialAuthDiscriminatorType.StaticBearer,
                _ => null,
            };
        }
    }
}