
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTextEditor20241022AllowedCaller
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
    public static class BetaTextEditor20241022AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20241022AllowedCaller value)
        {
            return value switch
            {
                BetaTextEditor20241022AllowedCaller.Direct => "direct",
                BetaTextEditor20241022AllowedCaller.CodeExecution20250825 => "code_execution_20250825",
                BetaTextEditor20241022AllowedCaller.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20241022AllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaTextEditor20241022AllowedCaller.Direct,
                "code_execution_20250825" => BetaTextEditor20241022AllowedCaller.CodeExecution20250825,
                "code_execution_20260120" => BetaTextEditor20241022AllowedCaller.CodeExecution20260120,
                _ => null,
            };
        }
    }
}