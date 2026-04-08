
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserToolConfirmationEventParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        UserToolConfirmation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserToolConfirmationEventParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserToolConfirmationEventParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsUserToolConfirmationEventParamsType.UserToolConfirmation => "user.tool_confirmation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserToolConfirmationEventParamsType? ToEnum(string value)
        {
            return value switch
            {
                "user.tool_confirmation" => BetaManagedAgentsUserToolConfirmationEventParamsType.UserToolConfirmation,
                _ => null,
            };
        }
    }
}