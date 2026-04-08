
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserInterruptEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserInterrupt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserInterruptEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserInterruptEventType value)
        {
            return value switch
            {
                BetaManagedAgentsUserInterruptEventType.UserInterrupt => "user.interrupt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserInterruptEventType? ToEnum(string value)
        {
            return value switch
            {
                "user.interrupt" => BetaManagedAgentsUserInterruptEventType.UserInterrupt,
                _ => null,
            };
        }
    }
}