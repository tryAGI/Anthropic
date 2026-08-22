
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentArchivedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentArchivedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentArchivedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentArchivedRunErrorType.AgentArchivedError => "agent_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentArchivedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_archived_error" => BetaManagedAgentsAgentArchivedRunErrorType.AgentArchivedError,
                _ => null,
            };
        }
    }
}