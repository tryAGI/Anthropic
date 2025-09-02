
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextEditorCodeExecutionToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextEditorCodeExecutionToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextEditorCodeExecutionToolResultBlockType value)
        {
            return value switch
            {
                BetaRequestTextEditorCodeExecutionToolResultBlockType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextEditorCodeExecutionToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result" => BetaRequestTextEditorCodeExecutionToolResultBlockType.TextEditorCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}