
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`.
    /// </summary>
    public enum BetaWorkspaceRateLimitGroupType
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
    public static class BetaWorkspaceRateLimitGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspaceRateLimitGroupType value)
        {
            return value switch
            {
                BetaWorkspaceRateLimitGroupType.Batch => "batch",
                BetaWorkspaceRateLimitGroupType.Files => "files",
                BetaWorkspaceRateLimitGroupType.ModelGroup => "model_group",
                BetaWorkspaceRateLimitGroupType.Skills => "skills",
                BetaWorkspaceRateLimitGroupType.TokenCount => "token_count",
                BetaWorkspaceRateLimitGroupType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspaceRateLimitGroupType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaWorkspaceRateLimitGroupType.Batch,
                "files" => BetaWorkspaceRateLimitGroupType.Files,
                "model_group" => BetaWorkspaceRateLimitGroupType.ModelGroup,
                "skills" => BetaWorkspaceRateLimitGroupType.Skills,
                "token_count" => BetaWorkspaceRateLimitGroupType.TokenCount,
                "web_search" => BetaWorkspaceRateLimitGroupType.WebSearch,
                _ => null,
            };
        }
    }
}