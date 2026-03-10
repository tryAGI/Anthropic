
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebFetchTool20260209AllowedCaller
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
    public static class BetaWebFetchTool20260209AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchTool20260209AllowedCaller value)
        {
            return value switch
            {
                BetaWebFetchTool20260209AllowedCaller.Direct => "direct",
                BetaWebFetchTool20260209AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                BetaWebFetchTool20260209AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchTool20260209AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaWebFetchTool20260209AllowedCaller.Direct,
                "code_execution_20250825" => BetaWebFetchTool20260209AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => BetaWebFetchTool20260209AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}