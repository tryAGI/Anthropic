
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserDefineOutcomeEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserDefineOutcome,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserDefineOutcomeEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserDefineOutcomeEventType value)
        {
            return value switch
            {
                BetaManagedAgentsUserDefineOutcomeEventType.UserDefineOutcome => "user.define_outcome",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserDefineOutcomeEventType? ToEnum(string value)
        {
            return value switch
            {
                "user.define_outcome" => BetaManagedAgentsUserDefineOutcomeEventType.UserDefineOutcome,
                _ => null,
            };
        }
    }
}