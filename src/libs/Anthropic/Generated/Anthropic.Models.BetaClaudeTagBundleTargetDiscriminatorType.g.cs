
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeTagBundleTargetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SlackChannel,
        /// <summary>
        ///
        /// </summary>
        SlackWorkspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeTagBundleTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeTagBundleTargetDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeTagBundleTargetDiscriminatorType.SlackChannel => "slack_channel",
                BetaClaudeTagBundleTargetDiscriminatorType.SlackWorkspace => "slack_workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeTagBundleTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "slack_channel" => BetaClaudeTagBundleTargetDiscriminatorType.SlackChannel,
                "slack_workspace" => BetaClaudeTagBundleTargetDiscriminatorType.SlackWorkspace,
                _ => null,
            };
        }
    }
}