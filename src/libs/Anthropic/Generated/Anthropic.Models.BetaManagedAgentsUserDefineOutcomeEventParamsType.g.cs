
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserDefineOutcomeEventParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        UserDefineOutcome,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserDefineOutcomeEventParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserDefineOutcomeEventParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsUserDefineOutcomeEventParamsType.UserDefineOutcome => "user.define_outcome",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserDefineOutcomeEventParamsType? ToEnum(string value)
        {
            return value switch
            {
                "user.define_outcome" => BetaManagedAgentsUserDefineOutcomeEventParamsType.UserDefineOutcome,
                _ => null,
            };
        }
    }
}