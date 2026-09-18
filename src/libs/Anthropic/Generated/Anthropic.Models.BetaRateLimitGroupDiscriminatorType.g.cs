
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRateLimitGroupDiscriminatorType
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
    public static class BetaRateLimitGroupDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRateLimitGroupDiscriminatorType value)
        {
            return value switch
            {
                BetaRateLimitGroupDiscriminatorType.Batch => "batch",
                BetaRateLimitGroupDiscriminatorType.Files => "files",
                BetaRateLimitGroupDiscriminatorType.ModelGroup => "model_group",
                BetaRateLimitGroupDiscriminatorType.Skills => "skills",
                BetaRateLimitGroupDiscriminatorType.TokenCount => "token_count",
                BetaRateLimitGroupDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRateLimitGroupDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaRateLimitGroupDiscriminatorType.Batch,
                "files" => BetaRateLimitGroupDiscriminatorType.Files,
                "model_group" => BetaRateLimitGroupDiscriminatorType.ModelGroup,
                "skills" => BetaRateLimitGroupDiscriminatorType.Skills,
                "token_count" => BetaRateLimitGroupDiscriminatorType.TokenCount,
                "web_search" => BetaRateLimitGroupDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}