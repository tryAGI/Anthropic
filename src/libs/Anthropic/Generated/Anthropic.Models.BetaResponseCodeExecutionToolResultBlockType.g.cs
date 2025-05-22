
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: code_execution_tool_result
    /// </summary>
    public enum BetaResponseCodeExecutionToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeExecutionToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeExecutionToolResultBlockType value)
        {
            return value switch
            {
                BetaResponseCodeExecutionToolResultBlockType.CodeExecutionToolResult => "code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeExecutionToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result" => BetaResponseCodeExecutionToolResultBlockType.CodeExecutionToolResult,
                _ => null,
            };
        }
    }
}