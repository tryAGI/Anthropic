
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Specifies who can invoke a tool.<br/>
    /// Values:<br/>
    ///     direct: The model can call this tool directly.<br/>
    ///     code_execution_20250825: The tool can be called from the code execution environment (v1).<br/>
    ///     code_execution_20260120: The tool can be called from the code execution environment (v2 with persistence).
    /// </summary>
    public enum AllowedCaller
    {
        /// <summary>
        /// The tool can be called from the code execution environment (v1).
        /// </summary>
        CodeExecution20250825,
        /// <summary>
        /// The tool can be called from the code execution environment (v2 with persistence).
        /// </summary>
        CodeExecution20260120,
        /// <summary>
        /// The model can call this tool directly.
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedCaller value)
        {
            return value switch
            {
                AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                AllowedCaller.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => AllowedCaller.CodeExecution20260120,
                "direct" => AllowedCaller.Direct,
                _ => null,
            };
        }
    }
}