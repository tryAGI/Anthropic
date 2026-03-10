
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolAllowedCaller
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
    public static class ToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolAllowedCaller value)
        {
            return value switch
            {
                ToolAllowedCaller.Direct => "direct",
                ToolAllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                ToolAllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolAllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => ToolAllowedCaller.Direct,
                "code_execution_20250825" => ToolAllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => ToolAllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}