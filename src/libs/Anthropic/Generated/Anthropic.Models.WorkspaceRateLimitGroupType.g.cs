
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Deprecated: use `group.type` instead. The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`. Always equal to `group.type`.
    /// </summary>
    public enum WorkspaceRateLimitGroupType
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
    public static class WorkspaceRateLimitGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceRateLimitGroupType value)
        {
            return value switch
            {
                WorkspaceRateLimitGroupType.Batch => "batch",
                WorkspaceRateLimitGroupType.Files => "files",
                WorkspaceRateLimitGroupType.ModelGroup => "model_group",
                WorkspaceRateLimitGroupType.Skills => "skills",
                WorkspaceRateLimitGroupType.TokenCount => "token_count",
                WorkspaceRateLimitGroupType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceRateLimitGroupType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => WorkspaceRateLimitGroupType.Batch,
                "files" => WorkspaceRateLimitGroupType.Files,
                "model_group" => WorkspaceRateLimitGroupType.ModelGroup,
                "skills" => WorkspaceRateLimitGroupType.Skills,
                "token_count" => WorkspaceRateLimitGroupType.TokenCount,
                "web_search" => WorkspaceRateLimitGroupType.WebSearch,
                _ => null,
            };
        }
    }
}