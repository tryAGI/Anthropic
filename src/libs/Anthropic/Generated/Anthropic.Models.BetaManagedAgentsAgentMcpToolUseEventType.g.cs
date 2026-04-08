
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentMcpToolUseEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMcpToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentMcpToolUseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentMcpToolUseEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentMcpToolUseEventType.AgentMcpToolUse => "agent.mcp_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentMcpToolUseEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.mcp_tool_use" => BetaManagedAgentsAgentMcpToolUseEventType.AgentMcpToolUse,
                _ => null,
            };
        }
    }
}