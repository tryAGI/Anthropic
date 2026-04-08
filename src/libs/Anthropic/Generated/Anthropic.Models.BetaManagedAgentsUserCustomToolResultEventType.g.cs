
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserCustomToolResultEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserCustomToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserCustomToolResultEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserCustomToolResultEventType value)
        {
            return value switch
            {
                BetaManagedAgentsUserCustomToolResultEventType.UserCustomToolResult => "user.custom_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserCustomToolResultEventType? ToEnum(string value)
        {
            return value switch
            {
                "user.custom_tool_result" => BetaManagedAgentsUserCustomToolResultEventType.UserCustomToolResult,
                _ => null,
            };
        }
    }
}