
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeTagGuestPolicyDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        ChannelOnly,
        /// <summary>
        ///
        /// </summary>
        Restrict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeTagGuestPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeTagGuestPolicyDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeTagGuestPolicyDiscriminatorType.Allow => "allow",
                BetaClaudeTagGuestPolicyDiscriminatorType.ChannelOnly => "channel_only",
                BetaClaudeTagGuestPolicyDiscriminatorType.Restrict => "restrict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeTagGuestPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allow" => BetaClaudeTagGuestPolicyDiscriminatorType.Allow,
                "channel_only" => BetaClaudeTagGuestPolicyDiscriminatorType.ChannelOnly,
                "restrict" => BetaClaudeTagGuestPolicyDiscriminatorType.Restrict,
                _ => null,
            };
        }
    }
}