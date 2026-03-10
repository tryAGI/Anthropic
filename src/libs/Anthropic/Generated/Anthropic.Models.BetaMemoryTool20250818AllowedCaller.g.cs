
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMemoryTool20250818AllowedCaller
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
    public static class BetaMemoryTool20250818AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818AllowedCaller value)
        {
            return value switch
            {
                BetaMemoryTool20250818AllowedCaller.Direct => "direct",
                BetaMemoryTool20250818AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                BetaMemoryTool20250818AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaMemoryTool20250818AllowedCaller.Direct,
                "code_execution_20250825" => BetaMemoryTool20250818AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => BetaMemoryTool20250818AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}