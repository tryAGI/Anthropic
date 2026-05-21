
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentThreadMessageReceivedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentThreadMessageReceived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentThreadMessageReceivedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentThreadMessageReceivedEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentThreadMessageReceivedEventType.AgentThreadMessageReceived => "agent.thread_message_received",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentThreadMessageReceivedEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.thread_message_received" => BetaManagedAgentsAgentThreadMessageReceivedEventType.AgentThreadMessageReceived,
                _ => null,
            };
        }
    }
}