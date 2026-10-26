
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Publicly documented product surfaces. `claude_tag` is Claude Tag, the Claude product in Slack. `chat_cowork_unified` is Chat and Cowork unified, Cowork's features inside claude.ai chat: chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified.
    /// </summary>
    public enum BetaAnalyticsUsageCostProductFilter
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
        ///
        /// </summary>
        ClaudeCode,
        /// <summary>
        ///
        /// </summary>
        ClaudeConsole,
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
        ClaudeTag,
        /// <summary>
        /// chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified.
        /// </summary>
        Cowork,
        /// <summary>
        ///
        /// </summary>
        ManagedAgentsApi,
        /// <summary>
        ///
        /// </summary>
        MessageBatchesApi,
        /// <summary>
        ///
        /// </summary>
        MessagesApi,
        /// <summary>
        ///
        /// </summary>
        OfficeAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsUsageCostProductFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageCostProductFilter value)
        {
            return value switch
            {
                BetaAnalyticsUsageCostProductFilter.Chat => "chat",
                BetaAnalyticsUsageCostProductFilter.ChatCoworkUnified => "chat_cowork_unified",
                BetaAnalyticsUsageCostProductFilter.ClaudeCode => "claude_code",
                BetaAnalyticsUsageCostProductFilter.ClaudeConsole => "claude_console",
                BetaAnalyticsUsageCostProductFilter.ClaudeDesign => "claude_design",
                BetaAnalyticsUsageCostProductFilter.ClaudeInChrome => "claude_in_chrome",
                BetaAnalyticsUsageCostProductFilter.ClaudeTag => "claude_tag",
                BetaAnalyticsUsageCostProductFilter.Cowork => "cowork",
                BetaAnalyticsUsageCostProductFilter.ManagedAgentsApi => "managed_agents_api",
                BetaAnalyticsUsageCostProductFilter.MessageBatchesApi => "message_batches_api",
                BetaAnalyticsUsageCostProductFilter.MessagesApi => "messages_api",
                BetaAnalyticsUsageCostProductFilter.OfficeAgent => "office_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageCostProductFilter? ToEnum(string value)
        {
            return value switch
            {
                "chat" => BetaAnalyticsUsageCostProductFilter.Chat,
                "chat_cowork_unified" => BetaAnalyticsUsageCostProductFilter.ChatCoworkUnified,
                "claude_code" => BetaAnalyticsUsageCostProductFilter.ClaudeCode,
                "claude_console" => BetaAnalyticsUsageCostProductFilter.ClaudeConsole,
                "claude_design" => BetaAnalyticsUsageCostProductFilter.ClaudeDesign,
                "claude_in_chrome" => BetaAnalyticsUsageCostProductFilter.ClaudeInChrome,
                "claude_tag" => BetaAnalyticsUsageCostProductFilter.ClaudeTag,
                "cowork" => BetaAnalyticsUsageCostProductFilter.Cowork,
                "managed_agents_api" => BetaAnalyticsUsageCostProductFilter.ManagedAgentsApi,
                "message_batches_api" => BetaAnalyticsUsageCostProductFilter.MessageBatchesApi,
                "messages_api" => BetaAnalyticsUsageCostProductFilter.MessagesApi,
                "office_agent" => BetaAnalyticsUsageCostProductFilter.OfficeAgent,
                _ => null,
            };
        }
    }
}