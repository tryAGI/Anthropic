
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Publicly documented product surfaces. `claude-tag` is Claude Tag, the Claude product in Slack.
    /// </summary>
    public enum BetaAnalyticsProductFilter
    {
        /// <summary>
        ///
        /// </summary>
        Chat,
        /// <summary>
        ///
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
        ///
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