
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseTextEditorCodeExecutionViewResultBlockFileType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextEditorCodeExecutionViewResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextEditorCodeExecutionViewResultBlockFileType value)
        {
            return value switch
            {
                BetaResponseTextEditorCodeExecutionViewResultBlockFileType.Text => "text",
                BetaResponseTextEditorCodeExecutionViewResultBlockFileType.Image => "image",
                BetaResponseTextEditorCodeExecutionViewResultBlockFileType.Pdf => "pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextEditorCodeExecutionViewResultBlockFileType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaResponseTextEditorCodeExecutionViewResultBlockFileType.Text,
                "image" => BetaResponseTextEditorCodeExecutionViewResultBlockFileType.Image,
                "pdf" => BetaResponseTextEditorCodeExecutionViewResultBlockFileType.Pdf,
                _ => null,
            };
        }
    }
}