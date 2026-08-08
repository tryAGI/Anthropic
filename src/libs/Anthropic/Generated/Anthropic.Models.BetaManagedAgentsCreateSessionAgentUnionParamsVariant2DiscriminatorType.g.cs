
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        AgentWithOverrides,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType.Agent => "agent",
                BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType.AgentWithOverrides => "agent_with_overrides",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType.Agent,
                "agent_with_overrides" => BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType.AgentWithOverrides,
                _ => null,
            };
        }
    }
}