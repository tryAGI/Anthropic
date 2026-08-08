
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserToolResultEventParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        UserToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserToolResultEventParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserToolResultEventParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsUserToolResultEventParamsType.UserToolResult => "user.tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserToolResultEventParamsType? ToEnum(string value)
        {
            return value switch
            {
                "user.tool_result" => BetaManagedAgentsUserToolResultEventParamsType.UserToolResult,
                _ => null,
            };
        }
    }
}