
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestBashCodeExecutionToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestBashCodeExecutionToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestBashCodeExecutionToolResultBlockType value)
        {
            return value switch
            {
                BetaRequestBashCodeExecutionToolResultBlockType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestBashCodeExecutionToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => BetaRequestBashCodeExecutionToolResultBlockType.BashCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}