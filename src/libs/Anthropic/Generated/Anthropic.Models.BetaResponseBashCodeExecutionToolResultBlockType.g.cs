
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: bash_code_execution_tool_result
    /// </summary>
    public enum BetaResponseBashCodeExecutionToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseBashCodeExecutionToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseBashCodeExecutionToolResultBlockType value)
        {
            return value switch
            {
                BetaResponseBashCodeExecutionToolResultBlockType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseBashCodeExecutionToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => BetaResponseBashCodeExecutionToolResultBlockType.BashCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}