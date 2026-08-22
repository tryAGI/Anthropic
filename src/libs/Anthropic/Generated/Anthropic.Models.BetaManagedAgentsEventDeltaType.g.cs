
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// EventDeltaType enum
    /// </summary>
    public enum BetaManagedAgentsEventDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
        /// <summary>
        /// 
        /// </summary>
        AgentThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEventDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventDeltaType value)
        {
            return value switch
            {
                BetaManagedAgentsEventDeltaType.AgentMessage => "agent.message",
                BetaManagedAgentsEventDeltaType.AgentThinking => "agent.thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "agent.message" => BetaManagedAgentsEventDeltaType.AgentMessage,
                "agent.thinking" => BetaManagedAgentsEventDeltaType.AgentThinking,
                _ => null,
            };
        }
    }
}