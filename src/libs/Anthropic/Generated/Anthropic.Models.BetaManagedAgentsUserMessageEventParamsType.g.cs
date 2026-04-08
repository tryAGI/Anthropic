
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserMessageEventParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserMessageEventParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserMessageEventParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsUserMessageEventParamsType.UserMessage => "user.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserMessageEventParamsType? ToEnum(string value)
        {
            return value switch
            {
                "user.message" => BetaManagedAgentsUserMessageEventParamsType.UserMessage,
                _ => null,
            };
        }
    }
}