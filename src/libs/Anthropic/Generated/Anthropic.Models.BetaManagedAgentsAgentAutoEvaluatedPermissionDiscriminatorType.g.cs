
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType
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
    public static class BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Allow => "allow",
                BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Ask => "ask",
                BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allow" => BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Allow,
                "ask" => BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Ask,
                "deny" => BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Deny,
                _ => null,
            };
        }
    }
}