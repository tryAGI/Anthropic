
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaComputerUseTool20250124AllowedCaller
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
    public static class BetaComputerUseTool20250124AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerUseTool20250124AllowedCaller value)
        {
            return value switch
            {
                BetaComputerUseTool20250124AllowedCaller.Direct => "direct",
                BetaComputerUseTool20250124AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                BetaComputerUseTool20250124AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerUseTool20250124AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaComputerUseTool20250124AllowedCaller.Direct,
                "code_execution_20250825" => BetaComputerUseTool20250124AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => BetaComputerUseTool20250124AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}