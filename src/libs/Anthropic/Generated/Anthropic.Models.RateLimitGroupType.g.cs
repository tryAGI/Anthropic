
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Deprecated: use `group.type` instead. The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`. Always equal to `group.type`.
    /// </summary>
    public enum RateLimitGroupType
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
        /// use `group.type` instead. The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`. Always equal to `group.type`.
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
    public static class RateLimitGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitGroupType value)
        {
            return value switch
            {
                RateLimitGroupType.Batch => "batch",
                RateLimitGroupType.Files => "files",
                RateLimitGroupType.ModelGroup => "model_group",
                RateLimitGroupType.Skills => "skills",
                RateLimitGroupType.TokenCount => "token_count",
                RateLimitGroupType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitGroupType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => RateLimitGroupType.Batch,
                "files" => RateLimitGroupType.Files,
                "model_group" => RateLimitGroupType.ModelGroup,
                "skills" => RateLimitGroupType.Skills,
                "token_count" => RateLimitGroupType.TokenCount,
                "web_search" => RateLimitGroupType.WebSearch,
                _ => null,
            };
        }
    }
}