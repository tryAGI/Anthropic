
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
    public static class RequestTextEditorCodeExecutionViewResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTextEditorCodeExecutionViewResultBlockFileType value)
        {
            return value switch
            {
                RequestTextEditorCodeExecutionViewResultBlockFileType.Text => "text",
                RequestTextEditorCodeExecutionViewResultBlockFileType.Image => "image",
                RequestTextEditorCodeExecutionViewResultBlockFileType.Pdf => "pdf",
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
                "text" => RequestTextEditorCodeExecutionViewResultBlockFileType.Text,
                "image" => RequestTextEditorCodeExecutionViewResultBlockFileType.Image,
                "pdf" => RequestTextEditorCodeExecutionViewResultBlockFileType.Pdf,
                _ => null,
            };
        }
    }
}