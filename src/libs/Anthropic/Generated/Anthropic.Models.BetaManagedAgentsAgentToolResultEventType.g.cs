
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentToolResultEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentToolResultEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolResultEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolResultEventType.AgentToolResult => "agent.tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolResultEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.tool_result" => BetaManagedAgentsAgentToolResultEventType.AgentToolResult,
                _ => null,
            };
        }
    }
}