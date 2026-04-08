
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentToolUseEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentToolUseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolUseEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolUseEventType.AgentToolUse => "agent.tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolUseEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.tool_use" => BetaManagedAgentsAgentToolUseEventType.AgentToolUse,
                _ => null,
            };
        }
    }
}