
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebFetchTool20250910AllowedCaller
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
    public static class BetaWebFetchTool20250910AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchTool20250910AllowedCaller value)
        {
            return value switch
            {
                BetaWebFetchTool20250910AllowedCaller.Direct => "direct",
                BetaWebFetchTool20250910AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                BetaWebFetchTool20250910AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchTool20250910AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaWebFetchTool20250910AllowedCaller.Direct,
                "code_execution_20250825" => BetaWebFetchTool20250910AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => BetaWebFetchTool20250910AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}