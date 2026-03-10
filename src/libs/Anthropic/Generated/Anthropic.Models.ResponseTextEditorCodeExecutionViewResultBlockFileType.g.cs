
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTextEditorCodeExecutionViewResultBlockFileType
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
    public static class ResponseTextEditorCodeExecutionViewResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextEditorCodeExecutionViewResultBlockFileType value)
        {
            return value switch
            {
                ResponseTextEditorCodeExecutionViewResultBlockFileType.Text => "text",
                ResponseTextEditorCodeExecutionViewResultBlockFileType.Image => "image",
                ResponseTextEditorCodeExecutionViewResultBlockFileType.Pdf => "pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextEditorCodeExecutionViewResultBlockFileType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseTextEditorCodeExecutionViewResultBlockFileType.Text,
                "image" => ResponseTextEditorCodeExecutionViewResultBlockFileType.Image,
                "pdf" => ResponseTextEditorCodeExecutionViewResultBlockFileType.Pdf,
                _ => null,
            };
        }
    }
}