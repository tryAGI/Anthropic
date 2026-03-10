
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeExecutionTool20250522AllowedCaller
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
    public static class CodeExecutionTool20250522AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionTool20250522AllowedCaller value)
        {
            return value switch
            {
                CodeExecutionTool20250522AllowedCaller.Direct => "direct",
                CodeExecutionTool20250522AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                CodeExecutionTool20250522AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionTool20250522AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => CodeExecutionTool20250522AllowedCaller.Direct,
                "code_execution_20250825" => CodeExecutionTool20250522AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => CodeExecutionTool20250522AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}