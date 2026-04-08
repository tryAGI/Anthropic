
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// AgentEvaluatedPermission enum
    /// </summary>
    public enum BetaManagedAgentsAgentEvaluatedPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Ask,
        /// <summary>
        /// 
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentEvaluatedPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentEvaluatedPermission value)
        {
            return value switch
            {
                BetaManagedAgentsAgentEvaluatedPermission.Allow => "allow",
                BetaManagedAgentsAgentEvaluatedPermission.Ask => "ask",
                BetaManagedAgentsAgentEvaluatedPermission.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentEvaluatedPermission? ToEnum(string value)
        {
            return value switch
            {
                "allow" => BetaManagedAgentsAgentEvaluatedPermission.Allow,
                "ask" => BetaManagedAgentsAgentEvaluatedPermission.Ask,
                "deny" => BetaManagedAgentsAgentEvaluatedPermission.Deny,
                _ => null,
            };
        }
    }
}