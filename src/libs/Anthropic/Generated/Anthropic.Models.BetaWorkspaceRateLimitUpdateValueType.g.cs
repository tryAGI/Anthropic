
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rate limiter type.
    /// </summary>
    public enum BetaWorkspaceRateLimitUpdateValueType
    {
        /// <summary>
        ///
        /// </summary>
        FastItpmca,
        /// <summary>
        ///
        /// </summary>
        FastOtpm,
        /// <summary>
        ///
        /// </summary>
        InputTokensPerMinute,
        /// <summary>
        ///
        /// </summary>
        InputTokensPerMinuteCacheAware,
        /// <summary>
        ///
        /// </summary>
        OutputTokensPerMinute,
        /// <summary>
        ///
        /// </summary>
        RequestsPerMinute,
        /// <summary>
        ///
        /// </summary>
        TokensPerDay,
        /// <summary>
        ///
        /// </summary>
        TokensPerMinute,
        /// <summary>
        ///
        /// </summary>
        ToolUsesPerSecond,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWorkspaceRateLimitUpdateValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspaceRateLimitUpdateValueType value)
        {
            return value switch
            {
                BetaWorkspaceRateLimitUpdateValueType.FastItpmca => "fast_itpmca",
                BetaWorkspaceRateLimitUpdateValueType.FastOtpm => "fast_otpm",
                BetaWorkspaceRateLimitUpdateValueType.InputTokensPerMinute => "input_tokens_per_minute",
                BetaWorkspaceRateLimitUpdateValueType.InputTokensPerMinuteCacheAware => "input_tokens_per_minute_cache_aware",
                BetaWorkspaceRateLimitUpdateValueType.OutputTokensPerMinute => "output_tokens_per_minute",
                BetaWorkspaceRateLimitUpdateValueType.RequestsPerMinute => "requests_per_minute",
                BetaWorkspaceRateLimitUpdateValueType.TokensPerDay => "tokens_per_day",
                BetaWorkspaceRateLimitUpdateValueType.TokensPerMinute => "tokens_per_minute",
                BetaWorkspaceRateLimitUpdateValueType.ToolUsesPerSecond => "tool_uses_per_second",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspaceRateLimitUpdateValueType? ToEnum(string value)
        {
            return value switch
            {
                "fast_itpmca" => BetaWorkspaceRateLimitUpdateValueType.FastItpmca,
                "fast_otpm" => BetaWorkspaceRateLimitUpdateValueType.FastOtpm,
                "input_tokens_per_minute" => BetaWorkspaceRateLimitUpdateValueType.InputTokensPerMinute,
                "input_tokens_per_minute_cache_aware" => BetaWorkspaceRateLimitUpdateValueType.InputTokensPerMinuteCacheAware,
                "output_tokens_per_minute" => BetaWorkspaceRateLimitUpdateValueType.OutputTokensPerMinute,
                "requests_per_minute" => BetaWorkspaceRateLimitUpdateValueType.RequestsPerMinute,
                "tokens_per_day" => BetaWorkspaceRateLimitUpdateValueType.TokensPerDay,
                "tokens_per_minute" => BetaWorkspaceRateLimitUpdateValueType.TokensPerMinute,
                "tool_uses_per_second" => BetaWorkspaceRateLimitUpdateValueType.ToolUsesPerSecond,
                _ => null,
            };
        }
    }
}