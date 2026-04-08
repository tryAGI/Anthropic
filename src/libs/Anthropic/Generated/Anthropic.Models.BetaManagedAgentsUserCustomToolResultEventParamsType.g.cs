
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserCustomToolResultEventParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        UserCustomToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserCustomToolResultEventParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserCustomToolResultEventParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsUserCustomToolResultEventParamsType.UserCustomToolResult => "user.custom_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserCustomToolResultEventParamsType? ToEnum(string value)
        {
            return value switch
            {
                "user.custom_tool_result" => BetaManagedAgentsUserCustomToolResultEventParamsType.UserCustomToolResult,
                _ => null,
            };
        }
    }
}