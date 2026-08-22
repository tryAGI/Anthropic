
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentWithOverridesParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentWithOverrides,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentWithOverridesParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentWithOverridesParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentWithOverridesParamsType.AgentWithOverrides => "agent_with_overrides",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentWithOverridesParamsType? ToEnum(string value)
        {
            return value switch
            {
                "agent_with_overrides" => BetaManagedAgentsAgentWithOverridesParamsType.AgentWithOverrides,
                _ => null,
            };
        }
    }
}