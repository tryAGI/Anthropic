
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventStartEventAgentMessagePreviewType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEventStartEventAgentMessagePreviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventStartEventAgentMessagePreviewType value)
        {
            return value switch
            {
                BetaManagedAgentsEventStartEventAgentMessagePreviewType.AgentMessage => "agent.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventStartEventAgentMessagePreviewType? ToEnum(string value)
        {
            return value switch
            {
                "agent.message" => BetaManagedAgentsEventStartEventAgentMessagePreviewType.AgentMessage,
                _ => null,
            };
        }
    }
}