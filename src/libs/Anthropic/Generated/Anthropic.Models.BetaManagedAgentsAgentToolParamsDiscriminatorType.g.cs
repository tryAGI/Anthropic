
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentToolParamsDiscriminatorType
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
    public static class BetaManagedAgentsAgentToolParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolParamsDiscriminatorType.AgentToolset20260401 => "agent_toolset_20260401",
                BetaManagedAgentsAgentToolParamsDiscriminatorType.Custom => "custom",
                BetaManagedAgentsAgentToolParamsDiscriminatorType.McpToolset => "mcp_toolset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_toolset_20260401" => BetaManagedAgentsAgentToolParamsDiscriminatorType.AgentToolset20260401,
                "custom" => BetaManagedAgentsAgentToolParamsDiscriminatorType.Custom,
                "mcp_toolset" => BetaManagedAgentsAgentToolParamsDiscriminatorType.McpToolset,
                _ => null,
            };
        }
    }
}