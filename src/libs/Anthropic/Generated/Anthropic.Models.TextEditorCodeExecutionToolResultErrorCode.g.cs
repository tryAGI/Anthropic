
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEditorCodeExecutionToolResultErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        FileNotFound,
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
    public static class TextEditorCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                TextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                TextEditorCodeExecutionToolResultErrorCode.FileNotFound => "file_not_found",
                TextEditorCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                TextEditorCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                TextEditorCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorCodeExecutionToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => TextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "file_not_found" => TextEditorCodeExecutionToolResultErrorCode.FileNotFound,
                "invalid_tool_input" => TextEditorCodeExecutionToolResultErrorCode.InvalidToolInput,
                "too_many_requests" => TextEditorCodeExecutionToolResultErrorCode.TooManyRequests,
                "unavailable" => TextEditorCodeExecutionToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}