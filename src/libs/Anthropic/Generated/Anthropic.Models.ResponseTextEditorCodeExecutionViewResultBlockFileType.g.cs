
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
    public static class ResponseTextEditorCodeExecutionViewResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextEditorCodeExecutionViewResultBlockFileType value)
        {
            return value switch
            {
                ResponseTextEditorCodeExecutionViewResultBlockFileType.Image => "image",
                ResponseTextEditorCodeExecutionViewResultBlockFileType.Pdf => "pdf",
                ResponseTextEditorCodeExecutionViewResultBlockFileType.Text => "text",
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
                "image" => ResponseTextEditorCodeExecutionViewResultBlockFileType.Image,
                "pdf" => ResponseTextEditorCodeExecutionViewResultBlockFileType.Pdf,
                "text" => ResponseTextEditorCodeExecutionViewResultBlockFileType.Text,
                _ => null,
            };
        }
    }
}