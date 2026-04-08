
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAlwaysAllowPolicyType
    {
        /// <summary>
        /// 
        /// </summary>
        AlwaysAllow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAlwaysAllowPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAlwaysAllowPolicyType value)
        {
            return value switch
            {
                BetaManagedAgentsAlwaysAllowPolicyType.AlwaysAllow => "always_allow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAlwaysAllowPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "always_allow" => BetaManagedAgentsAlwaysAllowPolicyType.AlwaysAllow,
                _ => null,
            };
        }
    }
}