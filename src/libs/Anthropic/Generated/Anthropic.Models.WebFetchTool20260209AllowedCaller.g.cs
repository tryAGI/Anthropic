
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebFetchTool20260209AllowedCaller
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
    public static class WebFetchTool20260209AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchTool20260209AllowedCaller value)
        {
            return value switch
            {
                WebFetchTool20260209AllowedCaller.Direct => "direct",
                WebFetchTool20260209AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                WebFetchTool20260209AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchTool20260209AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => WebFetchTool20260209AllowedCaller.Direct,
                "code_execution_20250825" => WebFetchTool20260209AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => WebFetchTool20260209AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}