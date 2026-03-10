
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolSearchToolResultErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchToolResultErrorCode value)
        {
            return value switch
            {
                ToolSearchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                ToolSearchToolResultErrorCode.Unavailable => "unavailable",
                ToolSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                ToolSearchToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => ToolSearchToolResultErrorCode.InvalidToolInput,
                "unavailable" => ToolSearchToolResultErrorCode.Unavailable,
                "too_many_requests" => ToolSearchToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => ToolSearchToolResultErrorCode.ExecutionTimeExceeded,
                _ => null,
            };
        }
    }
}