
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeTagSettingSourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        SlackChannel,
        /// <summary>
        ///
        /// </summary>
        SlackDefault,
        /// <summary>
        ///
        /// </summary>
        SlackGridChannel,
        /// <summary>
        ///
        /// </summary>
        SlackParentChannel,
        /// <summary>
        ///
        /// </summary>
        SlackWorkspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeTagSettingSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeTagSettingSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeTagSettingSourceDiscriminatorType.Default => "default",
                BetaClaudeTagSettingSourceDiscriminatorType.SlackChannel => "slack_channel",
                BetaClaudeTagSettingSourceDiscriminatorType.SlackDefault => "slack_default",
                BetaClaudeTagSettingSourceDiscriminatorType.SlackGridChannel => "slack_grid_channel",
                BetaClaudeTagSettingSourceDiscriminatorType.SlackParentChannel => "slack_parent_channel",
                BetaClaudeTagSettingSourceDiscriminatorType.SlackWorkspace => "slack_workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeTagSettingSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "default" => BetaClaudeTagSettingSourceDiscriminatorType.Default,
                "slack_channel" => BetaClaudeTagSettingSourceDiscriminatorType.SlackChannel,
                "slack_default" => BetaClaudeTagSettingSourceDiscriminatorType.SlackDefault,
                "slack_grid_channel" => BetaClaudeTagSettingSourceDiscriminatorType.SlackGridChannel,
                "slack_parent_channel" => BetaClaudeTagSettingSourceDiscriminatorType.SlackParentChannel,
                "slack_workspace" => BetaClaudeTagSettingSourceDiscriminatorType.SlackWorkspace,
                _ => null,
            };
        }
    }
}