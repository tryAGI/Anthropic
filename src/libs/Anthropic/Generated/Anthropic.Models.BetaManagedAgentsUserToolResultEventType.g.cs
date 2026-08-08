
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserToolResultEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserToolResultEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserToolResultEventType value)
        {
            return value switch
            {
                BetaManagedAgentsUserToolResultEventType.UserToolResult => "user.tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserToolResultEventType? ToEnum(string value)
        {
            return value switch
            {
                "user.tool_result" => BetaManagedAgentsUserToolResultEventType.UserToolResult,
                _ => null,
            };
        }
    }
}