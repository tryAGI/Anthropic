
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentToolset20260401,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        McpToolset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolDiscriminatorType.AgentToolset20260401 => "agent_toolset_20260401",
                BetaManagedAgentsAgentToolDiscriminatorType.Custom => "custom",
                BetaManagedAgentsAgentToolDiscriminatorType.McpToolset => "mcp_toolset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_toolset_20260401" => BetaManagedAgentsAgentToolDiscriminatorType.AgentToolset20260401,
                "custom" => BetaManagedAgentsAgentToolDiscriminatorType.Custom,
                "mcp_toolset" => BetaManagedAgentsAgentToolDiscriminatorType.McpToolset,
                _ => null,
            };
        }
    }
}