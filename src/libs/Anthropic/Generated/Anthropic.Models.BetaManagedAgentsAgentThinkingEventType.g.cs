
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentThinkingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentThinkingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentThinkingEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentThinkingEventType.AgentThinking => "agent.thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentThinkingEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.thinking" => BetaManagedAgentsAgentThinkingEventType.AgentThinking,
                _ => null,
            };
        }
    }
}