
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextEditorCodeExecutionViewResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionViewResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextEditorCodeExecutionViewResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextEditorCodeExecutionViewResultBlockType value)
        {
            return value switch
            {
                BetaRequestTextEditorCodeExecutionViewResultBlockType.TextEditorCodeExecutionViewResult => "text_editor_code_execution_view_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextEditorCodeExecutionViewResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_view_result" => BetaRequestTextEditorCodeExecutionViewResultBlockType.TextEditorCodeExecutionViewResult,
                _ => null,
            };
        }
    }
}