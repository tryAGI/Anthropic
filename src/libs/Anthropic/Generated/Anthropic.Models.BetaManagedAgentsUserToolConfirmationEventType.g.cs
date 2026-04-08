
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserToolConfirmationEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserToolConfirmation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserToolConfirmationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserToolConfirmationEventType value)
        {
            return value switch
            {
                BetaManagedAgentsUserToolConfirmationEventType.UserToolConfirmation => "user.tool_confirmation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserToolConfirmationEventType? ToEnum(string value)
        {
            return value switch
            {
                "user.tool_confirmation" => BetaManagedAgentsUserToolConfirmationEventType.UserToolConfirmation,
                _ => null,
            };
        }
    }
}