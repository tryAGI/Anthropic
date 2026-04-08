
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAlwaysAskPolicyType
    {
        /// <summary>
        /// 
        /// </summary>
        AlwaysAsk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAlwaysAskPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAlwaysAskPolicyType value)
        {
            return value switch
            {
                BetaManagedAgentsAlwaysAskPolicyType.AlwaysAsk => "always_ask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAlwaysAskPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "always_ask" => BetaManagedAgentsAlwaysAskPolicyType.AlwaysAsk,
                _ => null,
            };
        }
    }
}