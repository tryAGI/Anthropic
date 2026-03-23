
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
    public static class BetaTextEditorCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditorCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BetaTextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BetaTextEditorCodeExecutionToolResultErrorCode.FileNotFound => "file_not_found",
                BetaTextEditorCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaTextEditorCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaTextEditorCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
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
                "execution_time_exceeded" => BetaTextEditorCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "file_not_found" => BetaTextEditorCodeExecutionToolResultErrorCode.FileNotFound,
                "invalid_tool_input" => BetaTextEditorCodeExecutionToolResultErrorCode.InvalidToolInput,
                "too_many_requests" => BetaTextEditorCodeExecutionToolResultErrorCode.TooManyRequests,
                "unavailable" => BetaTextEditorCodeExecutionToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}