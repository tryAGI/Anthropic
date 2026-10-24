
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType
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
    public static class BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType.SlackChannel => "slack_channel",
                BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType.SlackWorkspace => "slack_workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "slack_channel" => BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType.SlackChannel,
                "slack_workspace" => BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType.SlackWorkspace,
                _ => null,
            };
        }
    }
}