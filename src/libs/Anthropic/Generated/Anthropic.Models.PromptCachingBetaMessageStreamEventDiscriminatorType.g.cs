
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCachingBetaMessageStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentBlockDelta,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockStart,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockStop,
        /// <summary>
        /// 
        /// </summary>
        MessageDelta,
        /// <summary>
        /// 
        /// </summary>
        MessageStart,
        /// <summary>
        /// 
        /// </summary>
        MessageStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaMessageStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaMessageStreamEventDiscriminatorType value)
        {
            return value switch
            {
                PromptCachingBetaMessageStreamEventDiscriminatorType.ContentBlockDelta => "content_block_delta",
                PromptCachingBetaMessageStreamEventDiscriminatorType.ContentBlockStart => "content_block_start",
                PromptCachingBetaMessageStreamEventDiscriminatorType.ContentBlockStop => "content_block_stop",
                PromptCachingBetaMessageStreamEventDiscriminatorType.MessageDelta => "message_delta",
                PromptCachingBetaMessageStreamEventDiscriminatorType.MessageStart => "message_start",
                PromptCachingBetaMessageStreamEventDiscriminatorType.MessageStop => "message_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaMessageStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_delta" => PromptCachingBetaMessageStreamEventDiscriminatorType.ContentBlockDelta,
                "content_block_start" => PromptCachingBetaMessageStreamEventDiscriminatorType.ContentBlockStart,
                "content_block_stop" => PromptCachingBetaMessageStreamEventDiscriminatorType.ContentBlockStop,
                "message_delta" => PromptCachingBetaMessageStreamEventDiscriminatorType.MessageDelta,
                "message_start" => PromptCachingBetaMessageStreamEventDiscriminatorType.MessageStart,
                "message_stop" => PromptCachingBetaMessageStreamEventDiscriminatorType.MessageStop,
                _ => null,
            };
        }
    }
}