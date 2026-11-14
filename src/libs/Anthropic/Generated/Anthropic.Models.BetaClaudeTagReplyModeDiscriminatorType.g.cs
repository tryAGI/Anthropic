
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeTagReplyModeDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AlwaysAwake,
        /// <summary>
        ///
        /// </summary>
        Automatic,
        /// <summary>
        ///
        /// </summary>
        MentionOnly,
        /// <summary>
        ///
        /// </summary>
        Thread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeTagReplyModeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeTagReplyModeDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeTagReplyModeDiscriminatorType.AlwaysAwake => "always_awake",
                BetaClaudeTagReplyModeDiscriminatorType.Automatic => "automatic",
                BetaClaudeTagReplyModeDiscriminatorType.MentionOnly => "mention_only",
                BetaClaudeTagReplyModeDiscriminatorType.Thread => "thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeTagReplyModeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "always_awake" => BetaClaudeTagReplyModeDiscriminatorType.AlwaysAwake,
                "automatic" => BetaClaudeTagReplyModeDiscriminatorType.Automatic,
                "mention_only" => BetaClaudeTagReplyModeDiscriminatorType.MentionOnly,
                "thread" => BetaClaudeTagReplyModeDiscriminatorType.Thread,
                _ => null,
            };
        }
    }
}