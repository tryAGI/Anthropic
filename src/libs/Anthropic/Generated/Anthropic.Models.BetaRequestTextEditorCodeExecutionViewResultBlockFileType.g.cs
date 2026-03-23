
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextEditorCodeExecutionViewResultBlockFileType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextEditorCodeExecutionViewResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextEditorCodeExecutionViewResultBlockFileType value)
        {
            return value switch
            {
                BetaRequestTextEditorCodeExecutionViewResultBlockFileType.Image => "image",
                BetaRequestTextEditorCodeExecutionViewResultBlockFileType.Pdf => "pdf",
                BetaRequestTextEditorCodeExecutionViewResultBlockFileType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextEditorCodeExecutionViewResultBlockFileType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaRequestTextEditorCodeExecutionViewResultBlockFileType.Image,
                "pdf" => BetaRequestTextEditorCodeExecutionViewResultBlockFileType.Pdf,
                "text" => BetaRequestTextEditorCodeExecutionViewResultBlockFileType.Text,
                _ => null,
            };
        }
    }
}