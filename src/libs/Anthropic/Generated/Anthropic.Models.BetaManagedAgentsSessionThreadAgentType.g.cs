
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadAgentType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadAgentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadAgentType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadAgentType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadAgentType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BetaManagedAgentsSessionThreadAgentType.Agent,
                _ => null,
            };
        }
    }
}