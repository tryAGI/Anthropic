
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWorkspaceRateLimitGroupDiscriminatorType
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
    public static class BetaWorkspaceRateLimitGroupDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspaceRateLimitGroupDiscriminatorType value)
        {
            return value switch
            {
                BetaWorkspaceRateLimitGroupDiscriminatorType.Batch => "batch",
                BetaWorkspaceRateLimitGroupDiscriminatorType.Files => "files",
                BetaWorkspaceRateLimitGroupDiscriminatorType.ModelGroup => "model_group",
                BetaWorkspaceRateLimitGroupDiscriminatorType.Skills => "skills",
                BetaWorkspaceRateLimitGroupDiscriminatorType.TokenCount => "token_count",
                BetaWorkspaceRateLimitGroupDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspaceRateLimitGroupDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaWorkspaceRateLimitGroupDiscriminatorType.Batch,
                "files" => BetaWorkspaceRateLimitGroupDiscriminatorType.Files,
                "model_group" => BetaWorkspaceRateLimitGroupDiscriminatorType.ModelGroup,
                "skills" => BetaWorkspaceRateLimitGroupDiscriminatorType.Skills,
                "token_count" => BetaWorkspaceRateLimitGroupDiscriminatorType.TokenCount,
                "web_search" => BetaWorkspaceRateLimitGroupDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}