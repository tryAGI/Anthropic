
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeExecutionTool20260120AllowedCaller
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
    public static class CodeExecutionTool20260120AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionTool20260120AllowedCaller value)
        {
            return value switch
            {
                CodeExecutionTool20260120AllowedCaller.Direct => "direct",
                CodeExecutionTool20260120AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                CodeExecutionTool20260120AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionTool20260120AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => CodeExecutionTool20260120AllowedCaller.Direct,
                "code_execution_20250825" => CodeExecutionTool20260120AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => CodeExecutionTool20260120AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}