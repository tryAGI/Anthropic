
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolAllowedCaller
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
    public static class BetaToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolAllowedCaller value)
        {
            return value switch
            {
                BetaToolAllowedCaller.Direct => "direct",
                BetaToolAllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                BetaToolAllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolAllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaToolAllowedCaller.Direct,
                "code_execution_20250825" => BetaToolAllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => BetaToolAllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}