
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolSearchToolBM2520251119AllowedCaller
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
    public static class ToolSearchToolBM2520251119AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchToolBM2520251119AllowedCaller value)
        {
            return value switch
            {
                ToolSearchToolBM2520251119AllowedCaller.Direct => "direct",
                ToolSearchToolBM2520251119AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                ToolSearchToolBM2520251119AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchToolBM2520251119AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => ToolSearchToolBM2520251119AllowedCaller.Direct,
                "code_execution_20250825" => ToolSearchToolBM2520251119AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => ToolSearchToolBM2520251119AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}