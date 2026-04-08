
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentToolset20260401ParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentToolset20260401,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentToolset20260401ParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolset20260401ParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolset20260401ParamsType.AgentToolset20260401 => "agent_toolset_20260401",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolset20260401ParamsType? ToEnum(string value)
        {
            return value switch
            {
                "agent_toolset_20260401" => BetaManagedAgentsAgentToolset20260401ParamsType.AgentToolset20260401,
                _ => null,
            };
        }
    }
}