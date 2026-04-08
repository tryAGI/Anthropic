
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsPermissionPolicyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AlwaysAllow,
        /// <summary>
        /// 
        /// </summary>
        AlwaysAsk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsPermissionPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsPermissionPolicyDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsPermissionPolicyDiscriminatorType.AlwaysAllow => "always_allow",
                BetaManagedAgentsPermissionPolicyDiscriminatorType.AlwaysAsk => "always_ask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsPermissionPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "always_allow" => BetaManagedAgentsPermissionPolicyDiscriminatorType.AlwaysAllow,
                "always_ask" => BetaManagedAgentsPermissionPolicyDiscriminatorType.AlwaysAsk,
                _ => null,
            };
        }
    }
}