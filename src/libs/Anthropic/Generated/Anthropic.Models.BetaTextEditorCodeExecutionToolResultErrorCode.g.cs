
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTextEditorCodeExecutionToolResultErrorCode
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
    public static class BetaTextEditorCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditorCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BetaTextEditorCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaTextEditorCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                BetaTextEditorCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaTextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BetaTextEditorCodeExecutionToolResultErrorCode.FileNotFound => "file_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditorCodeExecutionToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => BetaTextEditorCodeExecutionToolResultErrorCode.InvalidToolInput,
                "unavailable" => BetaTextEditorCodeExecutionToolResultErrorCode.Unavailable,
                "too_many_requests" => BetaTextEditorCodeExecutionToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => BetaTextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "file_not_found" => BetaTextEditorCodeExecutionToolResultErrorCode.FileNotFound,
                _ => null,
            };
        }
    }
}