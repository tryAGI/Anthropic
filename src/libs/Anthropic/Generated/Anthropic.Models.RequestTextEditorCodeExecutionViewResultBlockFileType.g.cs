
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTextEditorCodeExecutionViewResultBlockFileType
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
    public static class RequestTextEditorCodeExecutionViewResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTextEditorCodeExecutionViewResultBlockFileType value)
        {
            return value switch
            {
                RequestTextEditorCodeExecutionViewResultBlockFileType.Image => "image",
                RequestTextEditorCodeExecutionViewResultBlockFileType.Pdf => "pdf",
                RequestTextEditorCodeExecutionViewResultBlockFileType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTextEditorCodeExecutionViewResultBlockFileType? ToEnum(string value)
        {
            return value switch
            {
                "image" => RequestTextEditorCodeExecutionViewResultBlockFileType.Image,
                "pdf" => RequestTextEditorCodeExecutionViewResultBlockFileType.Pdf,
                "text" => RequestTextEditorCodeExecutionViewResultBlockFileType.Text,
                _ => null,
            };
        }
    }
}