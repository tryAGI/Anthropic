
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Publicly documented product surfaces. `claude-tag` is Claude Tag, the Claude product in Slack. `chat_cowork_unified` is Chat and Cowork unified, Cowork's features inside claude.ai chat: chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified.
    /// </summary>
    public enum BetaAnalyticsProductFilter
    {
        /// <summary>
        /// chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified.
        /// </summary>
        Chat,
        /// <summary>
        /// chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified.
        /// </summary>
        ChatCoworkUnified,
        /// <summary>
        /// chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified.
        /// </summary>
        ClaudeTag,
        /// <summary>
        ///
        /// </summary>
        ClaudeCode,
        /// <summary>
        ///
        /// </summary>
        ClaudeDesign,
        /// <summary>
        ///
        /// </summary>
        ClaudeInChrome,
        /// <summary>
        /// chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified.
        /// </summary>
        Cowork,
        /// <summary>
        ///
        /// </summary>
        OfficeAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsProductFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsProductFilter value)
        {
            return value switch
            {
                BetaAnalyticsProductFilter.Chat => "chat",
                BetaAnalyticsProductFilter.ChatCoworkUnified => "chat_cowork_unified",
                BetaAnalyticsProductFilter.ClaudeTag => "claude-tag",
                BetaAnalyticsProductFilter.ClaudeCode => "claude_code",
                BetaAnalyticsProductFilter.ClaudeDesign => "claude_design",
                BetaAnalyticsProductFilter.ClaudeInChrome => "claude_in_chrome",
                BetaAnalyticsProductFilter.Cowork => "cowork",
                BetaAnalyticsProductFilter.OfficeAgent => "office_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsProductFilter? ToEnum(string value)
        {
            return value switch
            {
                "chat" => BetaAnalyticsProductFilter.Chat,
                "chat_cowork_unified" => BetaAnalyticsProductFilter.ChatCoworkUnified,
                "claude-tag" => BetaAnalyticsProductFilter.ClaudeTag,
                "claude_code" => BetaAnalyticsProductFilter.ClaudeCode,
                "claude_design" => BetaAnalyticsProductFilter.ClaudeDesign,
                "claude_in_chrome" => BetaAnalyticsProductFilter.ClaudeInChrome,
                "cowork" => BetaAnalyticsProductFilter.Cowork,
                "office_agent" => BetaAnalyticsProductFilter.OfficeAgent,
                _ => null,
            };
        }
    }
}