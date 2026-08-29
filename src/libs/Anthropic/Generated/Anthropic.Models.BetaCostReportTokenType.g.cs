
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCostReportTokenType
    {
        /// <summary>
        ///
        /// </summary>
        CacheCreationEphemeral1hInputTokens,
        /// <summary>
        ///
        /// </summary>
        CacheCreationEphemeral5mInputTokens,
        /// <summary>
        ///
        /// </summary>
        CacheReadInputTokens,
        /// <summary>
        ///
        /// </summary>
        OutputTokens,
        /// <summary>
        ///
        /// </summary>
        UncachedInputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCostReportTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCostReportTokenType value)
        {
            return value switch
            {
                BetaCostReportTokenType.CacheCreationEphemeral1hInputTokens => "cache_creation.ephemeral_1h_input_tokens",
                BetaCostReportTokenType.CacheCreationEphemeral5mInputTokens => "cache_creation.ephemeral_5m_input_tokens",
                BetaCostReportTokenType.CacheReadInputTokens => "cache_read_input_tokens",
                BetaCostReportTokenType.OutputTokens => "output_tokens",
                BetaCostReportTokenType.UncachedInputTokens => "uncached_input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCostReportTokenType? ToEnum(string value)
        {
            return value switch
            {
                "cache_creation.ephemeral_1h_input_tokens" => BetaCostReportTokenType.CacheCreationEphemeral1hInputTokens,
                "cache_creation.ephemeral_5m_input_tokens" => BetaCostReportTokenType.CacheCreationEphemeral5mInputTokens,
                "cache_read_input_tokens" => BetaCostReportTokenType.CacheReadInputTokens,
                "output_tokens" => BetaCostReportTokenType.OutputTokens,
                "uncached_input_tokens" => BetaCostReportTokenType.UncachedInputTokens,
                _ => null,
            };
        }
    }
}