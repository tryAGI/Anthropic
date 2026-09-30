
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum RateLimitGroupDiscriminatorType
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
    public static class RateLimitGroupDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitGroupDiscriminatorType value)
        {
            return value switch
            {
                RateLimitGroupDiscriminatorType.Batch => "batch",
                RateLimitGroupDiscriminatorType.Files => "files",
                RateLimitGroupDiscriminatorType.ModelGroup => "model_group",
                RateLimitGroupDiscriminatorType.Skills => "skills",
                RateLimitGroupDiscriminatorType.TokenCount => "token_count",
                RateLimitGroupDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitGroupDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => RateLimitGroupDiscriminatorType.Batch,
                "files" => RateLimitGroupDiscriminatorType.Files,
                "model_group" => RateLimitGroupDiscriminatorType.ModelGroup,
                "skills" => RateLimitGroupDiscriminatorType.Skills,
                "token_count" => RateLimitGroupDiscriminatorType.TokenCount,
                "web_search" => RateLimitGroupDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}