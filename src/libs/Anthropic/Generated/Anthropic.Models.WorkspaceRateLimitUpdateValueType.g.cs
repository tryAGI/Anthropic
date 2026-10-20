
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rate limiter type.
    /// </summary>
    public enum WorkspaceRateLimitUpdateValueType
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
    public static class WorkspaceRateLimitUpdateValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceRateLimitUpdateValueType value)
        {
            return value switch
            {
                WorkspaceRateLimitUpdateValueType.FastItpmca => "fast_itpmca",
                WorkspaceRateLimitUpdateValueType.FastOtpm => "fast_otpm",
                WorkspaceRateLimitUpdateValueType.InputTokensPerMinute => "input_tokens_per_minute",
                WorkspaceRateLimitUpdateValueType.InputTokensPerMinuteCacheAware => "input_tokens_per_minute_cache_aware",
                WorkspaceRateLimitUpdateValueType.OutputTokensPerMinute => "output_tokens_per_minute",
                WorkspaceRateLimitUpdateValueType.RequestsPerMinute => "requests_per_minute",
                WorkspaceRateLimitUpdateValueType.TokensPerDay => "tokens_per_day",
                WorkspaceRateLimitUpdateValueType.TokensPerMinute => "tokens_per_minute",
                WorkspaceRateLimitUpdateValueType.ToolUsesPerSecond => "tool_uses_per_second",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceRateLimitUpdateValueType? ToEnum(string value)
        {
            return value switch
            {
                "fast_itpmca" => WorkspaceRateLimitUpdateValueType.FastItpmca,
                "fast_otpm" => WorkspaceRateLimitUpdateValueType.FastOtpm,
                "input_tokens_per_minute" => WorkspaceRateLimitUpdateValueType.InputTokensPerMinute,
                "input_tokens_per_minute_cache_aware" => WorkspaceRateLimitUpdateValueType.InputTokensPerMinuteCacheAware,
                "output_tokens_per_minute" => WorkspaceRateLimitUpdateValueType.OutputTokensPerMinute,
                "requests_per_minute" => WorkspaceRateLimitUpdateValueType.RequestsPerMinute,
                "tokens_per_day" => WorkspaceRateLimitUpdateValueType.TokensPerDay,
                "tokens_per_minute" => WorkspaceRateLimitUpdateValueType.TokensPerMinute,
                "tool_uses_per_second" => WorkspaceRateLimitUpdateValueType.ToolUsesPerSecond,
                _ => null,
            };
        }
    }
}