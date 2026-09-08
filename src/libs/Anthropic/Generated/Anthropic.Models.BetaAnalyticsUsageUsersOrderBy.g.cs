
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsUsageUsersOrderBy
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
        TotalTokens,
        /// <summary>
        ///
        /// </summary>
        UncachedInputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsUsageUsersOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageUsersOrderBy value)
        {
            return value switch
            {
                BetaAnalyticsUsageUsersOrderBy.OutputTokens => "output_tokens",
                BetaAnalyticsUsageUsersOrderBy.Requests => "requests",
                BetaAnalyticsUsageUsersOrderBy.TotalTokens => "total_tokens",
                BetaAnalyticsUsageUsersOrderBy.UncachedInputTokens => "uncached_input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageUsersOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "output_tokens" => BetaAnalyticsUsageUsersOrderBy.OutputTokens,
                "requests" => BetaAnalyticsUsageUsersOrderBy.Requests,
                "total_tokens" => BetaAnalyticsUsageUsersOrderBy.TotalTokens,
                "uncached_input_tokens" => BetaAnalyticsUsageUsersOrderBy.UncachedInputTokens,
                _ => null,
            };
        }
    }
}