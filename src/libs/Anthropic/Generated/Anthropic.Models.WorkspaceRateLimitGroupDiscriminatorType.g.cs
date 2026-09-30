
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkspaceRateLimitGroupDiscriminatorType
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
    public static class WorkspaceRateLimitGroupDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceRateLimitGroupDiscriminatorType value)
        {
            return value switch
            {
                WorkspaceRateLimitGroupDiscriminatorType.Batch => "batch",
                WorkspaceRateLimitGroupDiscriminatorType.Files => "files",
                WorkspaceRateLimitGroupDiscriminatorType.ModelGroup => "model_group",
                WorkspaceRateLimitGroupDiscriminatorType.Skills => "skills",
                WorkspaceRateLimitGroupDiscriminatorType.TokenCount => "token_count",
                WorkspaceRateLimitGroupDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceRateLimitGroupDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => WorkspaceRateLimitGroupDiscriminatorType.Batch,
                "files" => WorkspaceRateLimitGroupDiscriminatorType.Files,
                "model_group" => WorkspaceRateLimitGroupDiscriminatorType.ModelGroup,
                "skills" => WorkspaceRateLimitGroupDiscriminatorType.Skills,
                "token_count" => WorkspaceRateLimitGroupDiscriminatorType.TokenCount,
                "web_search" => WorkspaceRateLimitGroupDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}