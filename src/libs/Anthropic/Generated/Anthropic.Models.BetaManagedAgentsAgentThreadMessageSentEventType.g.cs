
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentThreadMessageSentEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentThreadMessageSent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentThreadMessageSentEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentThreadMessageSentEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentThreadMessageSentEventType.AgentThreadMessageSent => "agent.thread_message_sent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentThreadMessageSentEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.thread_message_sent" => BetaManagedAgentsAgentThreadMessageSentEventType.AgentThreadMessageSent,
                _ => null,
            };
        }
    }
}