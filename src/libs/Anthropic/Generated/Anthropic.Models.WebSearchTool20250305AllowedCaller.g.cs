
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchTool20250305AllowedCaller
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
    public static class WebSearchTool20250305AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchTool20250305AllowedCaller value)
        {
            return value switch
            {
                WebSearchTool20250305AllowedCaller.Direct => "direct",
                WebSearchTool20250305AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                WebSearchTool20250305AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchTool20250305AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => WebSearchTool20250305AllowedCaller.Direct,
                "code_execution_20250825" => WebSearchTool20250305AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => WebSearchTool20250305AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}