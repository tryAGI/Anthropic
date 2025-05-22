
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestCodeExecutionToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestCodeExecutionToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestCodeExecutionToolResultBlockType value)
        {
            return value switch
            {
                BetaRequestCodeExecutionToolResultBlockType.CodeExecutionToolResult => "code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestCodeExecutionToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result" => BetaRequestCodeExecutionToolResultBlockType.CodeExecutionToolResult,
                _ => null,
            };
        }
    }
}