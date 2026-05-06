
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentReferenceType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentReferenceType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BetaManagedAgentsAgentReferenceType.Agent,
                _ => null,
            };
        }
    }
}