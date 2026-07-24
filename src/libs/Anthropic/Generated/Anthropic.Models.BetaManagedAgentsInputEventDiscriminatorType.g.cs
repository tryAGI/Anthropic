
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
        SystemMessage,
        /// <summary>
        /// 
        /// </summary>
        UserCustomToolResult,
        /// <summary>
        /// 
        /// </summary>
        UserDefineOutcome,
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
        /// <summary>
        /// 
        /// </summary>
        UserToolResult,
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
                BetaManagedAgentsInputEventDiscriminatorType.SystemMessage => "system.message",
                BetaManagedAgentsInputEventDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsInputEventDiscriminatorType.UserDefineOutcome => "user.define_outcome",
                BetaManagedAgentsInputEventDiscriminatorType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsInputEventDiscriminatorType.UserMessage => "user.message",
                BetaManagedAgentsInputEventDiscriminatorType.UserToolConfirmation => "user.tool_confirmation",
                BetaManagedAgentsInputEventDiscriminatorType.UserToolResult => "user.tool_result",
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
                "system.message" => BetaManagedAgentsInputEventDiscriminatorType.SystemMessage,
                "user.custom_tool_result" => BetaManagedAgentsInputEventDiscriminatorType.UserCustomToolResult,
                "user.define_outcome" => BetaManagedAgentsInputEventDiscriminatorType.UserDefineOutcome,
                "user.interrupt" => BetaManagedAgentsInputEventDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsInputEventDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsInputEventDiscriminatorType.UserToolConfirmation,
                "user.tool_result" => BetaManagedAgentsInputEventDiscriminatorType.UserToolResult,
                _ => null,
            };
        }
    }
}