
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
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
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
                ToolSearchToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                ToolSearchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                ToolSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                ToolSearchToolResultErrorCode.Unavailable => "unavailable",
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
                "execution_time_exceeded" => ToolSearchToolResultErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => ToolSearchToolResultErrorCode.InvalidToolInput,
                "too_many_requests" => ToolSearchToolResultErrorCode.TooManyRequests,
                "unavailable" => ToolSearchToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}