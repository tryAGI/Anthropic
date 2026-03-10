
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebFetchTool20250910AllowedCaller
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250825,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20260120,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchTool20250910AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchTool20250910AllowedCaller value)
        {
            return value switch
            {
                WebFetchTool20250910AllowedCaller.Direct => "direct",
                WebFetchTool20250910AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                WebFetchTool20250910AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchTool20250910AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => WebFetchTool20250910AllowedCaller.Direct,
                "code_execution_20250825" => WebFetchTool20250910AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => WebFetchTool20250910AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}