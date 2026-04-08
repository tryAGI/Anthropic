
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentMessageEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentMessageEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentMessageEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentMessageEventType.AgentMessage => "agent.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentMessageEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.message" => BetaManagedAgentsAgentMessageEventType.AgentMessage,
                _ => null,
            };
        }
    }
}