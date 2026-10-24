
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsFlatUsageOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        OutputTokens,
        /// <summary>
        ///
        /// </summary>
        Requests,
        /// <summary>
        ///
        /// </summary>
        Time,
        /// <summary>
        ///
        /// </summary>
        TotalTokens,
        /// <summary>
        ///
        /// </summary>
        UncachedInputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsFlatUsageOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsFlatUsageOrderBy value)
        {
            return value switch
            {
                BetaAnalyticsFlatUsageOrderBy.OutputTokens => "output_tokens",
                BetaAnalyticsFlatUsageOrderBy.Requests => "requests",
                BetaAnalyticsFlatUsageOrderBy.Time => "time",
                BetaAnalyticsFlatUsageOrderBy.TotalTokens => "total_tokens",
                BetaAnalyticsFlatUsageOrderBy.UncachedInputTokens => "uncached_input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsFlatUsageOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "output_tokens" => BetaAnalyticsFlatUsageOrderBy.OutputTokens,
                "requests" => BetaAnalyticsFlatUsageOrderBy.Requests,
                "time" => BetaAnalyticsFlatUsageOrderBy.Time,
                "total_tokens" => BetaAnalyticsFlatUsageOrderBy.TotalTokens,
                "uncached_input_tokens" => BetaAnalyticsFlatUsageOrderBy.UncachedInputTokens,
                _ => null,
            };
        }
    }
}