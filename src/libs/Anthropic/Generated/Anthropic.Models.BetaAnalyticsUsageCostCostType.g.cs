
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsUsageCostCostType
    {
        /// <summary>
        ///
        /// </summary>
        CodeExecution,
        /// <summary>
        ///
        /// </summary>
        SessionUsage,
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
    public static class BetaAnalyticsUsageCostCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageCostCostType value)
        {
            return value switch
            {
                BetaAnalyticsUsageCostCostType.CodeExecution => "code_execution",
                BetaAnalyticsUsageCostCostType.SessionUsage => "session_usage",
                BetaAnalyticsUsageCostCostType.Tokens => "tokens",
                BetaAnalyticsUsageCostCostType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageCostCostType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution" => BetaAnalyticsUsageCostCostType.CodeExecution,
                "session_usage" => BetaAnalyticsUsageCostCostType.SessionUsage,
                "tokens" => BetaAnalyticsUsageCostCostType.Tokens,
                "web_search" => BetaAnalyticsUsageCostCostType.WebSearch,
                _ => null,
            };
        }
    }
}