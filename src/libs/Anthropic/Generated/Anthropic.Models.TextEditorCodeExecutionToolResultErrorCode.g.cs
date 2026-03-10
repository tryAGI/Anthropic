
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
        /// <summary>
        /// 
        /// </summary>
        FileNotFound,
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
                TextEditorCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                TextEditorCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                TextEditorCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                TextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                TextEditorCodeExecutionToolResultErrorCode.FileNotFound => "file_not_found",
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
                "invalid_tool_input" => TextEditorCodeExecutionToolResultErrorCode.InvalidToolInput,
                "unavailable" => TextEditorCodeExecutionToolResultErrorCode.Unavailable,
                "too_many_requests" => TextEditorCodeExecutionToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => TextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "file_not_found" => TextEditorCodeExecutionToolResultErrorCode.FileNotFound,
                _ => null,
            };
        }
    }
}