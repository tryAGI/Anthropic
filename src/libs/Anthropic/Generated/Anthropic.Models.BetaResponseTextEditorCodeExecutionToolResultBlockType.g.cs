
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: text_editor_code_execution_tool_result
    /// </summary>
    public enum BetaResponseTextEditorCodeExecutionToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextEditorCodeExecutionToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextEditorCodeExecutionToolResultBlockType value)
        {
            return value switch
            {
                BetaResponseTextEditorCodeExecutionToolResultBlockType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextEditorCodeExecutionToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result" => BetaResponseTextEditorCodeExecutionToolResultBlockType.TextEditorCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}