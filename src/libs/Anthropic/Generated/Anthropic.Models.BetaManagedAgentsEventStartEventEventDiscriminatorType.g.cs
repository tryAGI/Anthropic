
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventStartEventEventDiscriminatorType
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
    public static class BetaManagedAgentsEventStartEventEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventStartEventEventDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsEventStartEventEventDiscriminatorType.AgentMessage => "agent.message",
                BetaManagedAgentsEventStartEventEventDiscriminatorType.AgentThinking => "agent.thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventStartEventEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent.message" => BetaManagedAgentsEventStartEventEventDiscriminatorType.AgentMessage,
                "agent.thinking" => BetaManagedAgentsEventStartEventEventDiscriminatorType.AgentThinking,
                _ => null,
            };
        }
    }
}