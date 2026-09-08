
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsCostType
    {
        /// <summary>
        ///
        /// </summary>
        CodeExecution,
        /// <summary>
        ///
        /// </summary>
        Tokens,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsCostType value)
        {
            return value switch
            {
                BetaAnalyticsCostType.CodeExecution => "code_execution",
                BetaAnalyticsCostType.Tokens => "tokens",
                BetaAnalyticsCostType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsCostType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution" => BetaAnalyticsCostType.CodeExecution,
                "tokens" => BetaAnalyticsCostType.Tokens,
                "web_search" => BetaAnalyticsCostType.WebSearch,
                _ => null,
            };
        }
    }
}