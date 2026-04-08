
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventParamsDiscriminatorType
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
    public static class BetaManagedAgentsEventParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsEventParamsDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsEventParamsDiscriminatorType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsEventParamsDiscriminatorType.UserMessage => "user.message",
                BetaManagedAgentsEventParamsDiscriminatorType.UserToolConfirmation => "user.tool_confirmation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "user.custom_tool_result" => BetaManagedAgentsEventParamsDiscriminatorType.UserCustomToolResult,
                "user.interrupt" => BetaManagedAgentsEventParamsDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsEventParamsDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsEventParamsDiscriminatorType.UserToolConfirmation,
                _ => null,
            };
        }
    }
}