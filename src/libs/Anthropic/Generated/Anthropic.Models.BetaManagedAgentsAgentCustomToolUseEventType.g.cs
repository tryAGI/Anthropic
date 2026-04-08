
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentCustomToolUseEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentCustomToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentCustomToolUseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentCustomToolUseEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentCustomToolUseEventType.AgentCustomToolUse => "agent.custom_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentCustomToolUseEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.custom_tool_use" => BetaManagedAgentsAgentCustomToolUseEventType.AgentCustomToolUse,
                _ => null,
            };
        }
    }
}