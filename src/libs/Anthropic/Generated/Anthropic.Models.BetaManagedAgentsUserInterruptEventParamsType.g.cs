
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserInterruptEventParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        UserInterrupt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserInterruptEventParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserInterruptEventParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsUserInterruptEventParamsType.UserInterrupt => "user.interrupt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserInterruptEventParamsType? ToEnum(string value)
        {
            return value switch
            {
                "user.interrupt" => BetaManagedAgentsUserInterruptEventParamsType.UserInterrupt,
                _ => null,
            };
        }
    }
}