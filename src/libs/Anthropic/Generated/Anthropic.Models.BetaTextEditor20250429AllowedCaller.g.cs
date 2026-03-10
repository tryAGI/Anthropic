
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTextEditor20250429AllowedCaller
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
    public static class BetaTextEditor20250429AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20250429AllowedCaller value)
        {
            return value switch
            {
                BetaTextEditor20250429AllowedCaller.Direct => "direct",
                BetaTextEditor20250429AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                BetaTextEditor20250429AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20250429AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaTextEditor20250429AllowedCaller.Direct,
                "code_execution_20250825" => BetaTextEditor20250429AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => BetaTextEditor20250429AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}