
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`.
    /// </summary>
    public enum BetaRateLimitGroupType
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Files,
        /// <summary>
        ///
        /// </summary>
        ModelGroup,
        /// <summary>
        ///
        /// </summary>
        Skills,
        /// <summary>
        ///
        /// </summary>
        TokenCount,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRateLimitGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRateLimitGroupType value)
        {
            return value switch
            {
                BetaRateLimitGroupType.Batch => "batch",
                BetaRateLimitGroupType.Files => "files",
                BetaRateLimitGroupType.ModelGroup => "model_group",
                BetaRateLimitGroupType.Skills => "skills",
                BetaRateLimitGroupType.TokenCount => "token_count",
                BetaRateLimitGroupType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRateLimitGroupType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaRateLimitGroupType.Batch,
                "files" => BetaRateLimitGroupType.Files,
                "model_group" => BetaRateLimitGroupType.ModelGroup,
                "skills" => BetaRateLimitGroupType.Skills,
                "token_count" => BetaRateLimitGroupType.TokenCount,
                "web_search" => BetaRateLimitGroupType.WebSearch,
                _ => null,
            };
        }
    }
}