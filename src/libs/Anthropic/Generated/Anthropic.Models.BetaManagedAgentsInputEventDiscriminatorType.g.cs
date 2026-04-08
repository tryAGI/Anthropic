
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsInputEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        UserCustomToolResult,
        /// <summary>
        /// 
        /// </summary>
        UserInterrupt,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
        /// <summary>
        /// 
        /// </summary>
        UserToolConfirmation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsInputEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsInputEventDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsInputEventDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsInputEventDiscriminatorType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsInputEventDiscriminatorType.UserMessage => "user.message",
                BetaManagedAgentsInputEventDiscriminatorType.UserToolConfirmation => "user.tool_confirmation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsInputEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "user.custom_tool_result" => BetaManagedAgentsInputEventDiscriminatorType.UserCustomToolResult,
                "user.interrupt" => BetaManagedAgentsInputEventDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsInputEventDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsInputEventDiscriminatorType.UserToolConfirmation,
                _ => null,
            };
        }
    }
}