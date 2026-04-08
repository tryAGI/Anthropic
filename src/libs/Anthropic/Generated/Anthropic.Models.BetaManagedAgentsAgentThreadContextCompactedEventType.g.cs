
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentThreadContextCompactedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentThreadContextCompacted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentThreadContextCompactedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentThreadContextCompactedEventType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentThreadContextCompactedEventType.AgentThreadContextCompacted => "agent.thread_context_compacted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentThreadContextCompactedEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.thread_context_compacted" => BetaManagedAgentsAgentThreadContextCompactedEventType.AgentThreadContextCompacted,
                _ => null,
            };
        }
    }
}