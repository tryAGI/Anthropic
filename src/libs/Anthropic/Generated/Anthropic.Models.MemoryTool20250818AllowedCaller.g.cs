
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum MemoryTool20250818AllowedCaller
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
    public static class MemoryTool20250818AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoryTool20250818AllowedCaller value)
        {
            return value switch
            {
                MemoryTool20250818AllowedCaller.Direct => "direct",
                MemoryTool20250818AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                MemoryTool20250818AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoryTool20250818AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => MemoryTool20250818AllowedCaller.Direct,
                "code_execution_20250825" => MemoryTool20250818AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => MemoryTool20250818AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}