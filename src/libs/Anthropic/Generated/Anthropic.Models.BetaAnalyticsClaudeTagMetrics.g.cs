
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude Tag activity metrics for a single linked user on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsClaudeTagMetrics
    {
        /// <summary>
        /// 1 on a day the user was active in Claude Tag in Slack, otherwise 0. Summed over the window in date-range mode, so it is the number of active days; on grouped rows, the total of each member's active days. Null when Claude Tag data cannot be read for the request. Otherwise, 0 on a row filtered by project, and null on any other row when no covered day was measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_day_count")]
        public int? ActiveDayCount { get; set; }

        /// <summary>
        /// Number of the user's Slack messages that made them active: @-mentions, direct messages, group direct message asks, and thread posts Claude answered. Other messages are not counted. Null when Claude Tag data cannot be read for the request. Otherwise, 0 on a row filtered by project, and null on any other row when no covered day was measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_message_count")]
        public int? ActiveMessageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsClaudeTagMetrics" /> class.
        /// </summary>
        /// <param name="activeDayCount">
        /// 1 on a day the user was active in Claude Tag in Slack, otherwise 0. Summed over the window in date-range mode, so it is the number of active days; on grouped rows, the total of each member's active days. Null when Claude Tag data cannot be read for the request. Otherwise, 0 on a row filtered by project, and null on any other row when no covered day was measured.
        /// </param>
        /// <param name="activeMessageCount">
        /// Number of the user's Slack messages that made them active: @-mentions, direct messages, group direct message asks, and thread posts Claude answered. Other messages are not counted. Null when Claude Tag data cannot be read for the request. Otherwise, 0 on a row filtered by project, and null on any other row when no covered day was measured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsClaudeTagMetrics(
            int? activeDayCount,
            int? activeMessageCount)
        {
            this.ActiveDayCount = activeDayCount;
            this.ActiveMessageCount = activeMessageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsClaudeTagMetrics" /> class.
        /// </summary>
        public BetaAnalyticsClaudeTagMetrics()
        {
        }

    }
}