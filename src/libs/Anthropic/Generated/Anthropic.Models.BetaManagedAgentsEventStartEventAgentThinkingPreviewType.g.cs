
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventStartEventAgentThinkingPreviewType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEventStartEventAgentThinkingPreviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventStartEventAgentThinkingPreviewType value)
        {
            return value switch
            {
                BetaManagedAgentsEventStartEventAgentThinkingPreviewType.AgentThinking => "agent.thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventStartEventAgentThinkingPreviewType? ToEnum(string value)
        {
            return value switch
            {
                "agent.thinking" => BetaManagedAgentsEventStartEventAgentThinkingPreviewType.AgentThinking,
                _ => null,
            };
        }
    }
}