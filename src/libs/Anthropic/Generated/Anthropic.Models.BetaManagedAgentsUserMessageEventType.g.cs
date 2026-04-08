
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserMessageEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserMessageEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserMessageEventType value)
        {
            return value switch
            {
                BetaManagedAgentsUserMessageEventType.UserMessage => "user.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserMessageEventType? ToEnum(string value)
        {
            return value switch
            {
                "user.message" => BetaManagedAgentsUserMessageEventType.UserMessage,
                _ => null,
            };
        }
    }
}