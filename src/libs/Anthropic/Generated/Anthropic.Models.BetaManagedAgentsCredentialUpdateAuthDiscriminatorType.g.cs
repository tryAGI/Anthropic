
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialUpdateAuthDiscriminatorType
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
    public static class BetaManagedAgentsCredentialUpdateAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialUpdateAuthDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialUpdateAuthDiscriminatorType.McpOauth => "mcp_oauth",
                BetaManagedAgentsCredentialUpdateAuthDiscriminatorType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => BetaManagedAgentsCredentialUpdateAuthDiscriminatorType.McpOauth,
                "static_bearer" => BetaManagedAgentsCredentialUpdateAuthDiscriminatorType.StaticBearer,
                _ => null,
            };
        }
    }
}