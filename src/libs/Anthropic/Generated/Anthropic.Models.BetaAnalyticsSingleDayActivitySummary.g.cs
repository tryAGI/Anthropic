
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-day entry in the /summaries response.
    /// </summary>
    public sealed partial class BetaAnalyticsSingleDayActivitySummary
    {
        /// <summary>
        /// Number of seats currently assigned to members. Null when the response is scoped to an RBAC group — seat assignment is org-wide and has no per-group analogue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_seat_count")]
        public int? AssignedSeatCount { get; set; }

        /// <summary>
        /// Number of users with claude.ai (chat) activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_daily_active_user_count")]
        public int? ChatDailyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with claude.ai (chat) activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_monthly_active_user_count")]
        public int? ChatMonthlyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with claude.ai (chat) activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_weekly_active_user_count")]
        public int? ChatWeeklyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Code activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code_daily_active_user_count")]
        public int? ClaudeCodeDailyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Code activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code_monthly_active_user_count")]
        public int? ClaudeCodeMonthlyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Code activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code_weekly_active_user_count")]
        public int? ClaudeCodeWeeklyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Design activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_design_daily_active_user_count")]
        public int? ClaudeDesignDailyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Design activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_design_monthly_active_user_count")]
        public int? ClaudeDesignMonthlyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Design activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_design_weekly_active_user_count")]
        public int? ClaudeDesignWeeklyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Cowork activity on the requested day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cowork_daily_active_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CoworkDailyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Cowork activity in the 30-day rolling window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cowork_monthly_active_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CoworkMonthlyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Cowork activity in the 7-day rolling window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cowork_weekly_active_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CoworkWeeklyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with token consumption on the requested day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_active_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DailyActiveUserCount { get; set; }

        /// <summary>
        /// Percentage of assigned seats with activity on the requested day (`DAU / assigned_seat_count * 100`). Null when the response is scoped to an RBAC group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_adoption_rate")]
        public double? DailyAdoptionRate { get; set; }

        /// <summary>
        /// End of the aggregation period (exclusive), UTC midnight in RFC 3339 format (e.g. `2026-01-16T00:00:00Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndingAt { get; set; }

        /// <summary>
        /// Number of users with token consumption in the 30-day rolling window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_active_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyActiveUserCount { get; set; }

        /// <summary>
        /// Percentage of assigned seats with activity in the 30-day rolling window (`MAU / assigned_seat_count * 100`). Null when the response is scoped to an RBAC group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_adoption_rate")]
        public double? MonthlyAdoptionRate { get; set; }

        /// <summary>
        /// Number of users with Claude in Office activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("office_agent_daily_active_user_count")]
        public int? OfficeAgentDailyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude in Office activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("office_agent_monthly_active_user_count")]
        public int? OfficeAgentMonthlyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude in Office activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("office_agent_weekly_active_user_count")]
        public int? OfficeAgentWeeklyActiveUserCount { get; set; }

        /// <summary>
        /// Number of pending invitations to join the organization. Null when the response is scoped to an RBAC group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_invite_count")]
        public int? PendingInviteCount { get; set; }

        /// <summary>
        /// Number of users with Claude Science activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("science_daily_active_user_count")]
        public int? ScienceDailyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with a Claude Science seat entitlement (per-seat RBAC) at the time of the daily snapshot. The funnel top; independent of the org-level Claude Science toggle. Null when the response is scoped to an RBAC group — entitlement is org-wide and has no per-group analogue. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("science_entitled_user_count")]
        public int? ScienceEntitledUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Science activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("science_monthly_active_user_count")]
        public int? ScienceMonthlyActiveUserCount { get; set; }

        /// <summary>
        /// Number of users with Claude Science activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("science_weekly_active_user_count")]
        public int? ScienceWeeklyActiveUserCount { get; set; }

        /// <summary>
        /// Start of the aggregation period (inclusive), UTC midnight in RFC 3339 format (e.g. `2026-01-15T00:00:00Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartingAt { get; set; }

        /// <summary>
        /// Number of users with token consumption in the 7-day rolling window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekly_active_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WeeklyActiveUserCount { get; set; }

        /// <summary>
        /// Percentage of assigned seats with activity in the 7-day rolling window (`WAU / assigned_seat_count * 100`). Null when the response is scoped to an RBAC group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekly_adoption_rate")]
        public double? WeeklyAdoptionRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSingleDayActivitySummary" /> class.
        /// </summary>
        /// <param name="coworkDailyActiveUserCount">
        /// Number of users with Cowork activity on the requested day
        /// </param>
        /// <param name="coworkMonthlyActiveUserCount">
        /// Number of users with Cowork activity in the 30-day rolling window
        /// </param>
        /// <param name="coworkWeeklyActiveUserCount">
        /// Number of users with Cowork activity in the 7-day rolling window
        /// </param>
        /// <param name="dailyActiveUserCount">
        /// Number of users with token consumption on the requested day
        /// </param>
        /// <param name="endingAt">
        /// End of the aggregation period (exclusive), UTC midnight in RFC 3339 format (e.g. `2026-01-16T00:00:00Z`).
        /// </param>
        /// <param name="monthlyActiveUserCount">
        /// Number of users with token consumption in the 30-day rolling window
        /// </param>
        /// <param name="startingAt">
        /// Start of the aggregation period (inclusive), UTC midnight in RFC 3339 format (e.g. `2026-01-15T00:00:00Z`).
        /// </param>
        /// <param name="weeklyActiveUserCount">
        /// Number of users with token consumption in the 7-day rolling window
        /// </param>
        /// <param name="assignedSeatCount">
        /// Number of seats currently assigned to members. Null when the response is scoped to an RBAC group — seat assignment is org-wide and has no per-group analogue.
        /// </param>
        /// <param name="chatDailyActiveUserCount">
        /// Number of users with claude.ai (chat) activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="chatMonthlyActiveUserCount">
        /// Number of users with claude.ai (chat) activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="chatWeeklyActiveUserCount">
        /// Number of users with claude.ai (chat) activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="claudeCodeDailyActiveUserCount">
        /// Number of users with Claude Code activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="claudeCodeMonthlyActiveUserCount">
        /// Number of users with Claude Code activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="claudeCodeWeeklyActiveUserCount">
        /// Number of users with Claude Code activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="claudeDesignDailyActiveUserCount">
        /// Number of users with Claude Design activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="claudeDesignMonthlyActiveUserCount">
        /// Number of users with Claude Design activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="claudeDesignWeeklyActiveUserCount">
        /// Number of users with Claude Design activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="dailyAdoptionRate">
        /// Percentage of assigned seats with activity on the requested day (`DAU / assigned_seat_count * 100`). Null when the response is scoped to an RBAC group.
        /// </param>
        /// <param name="monthlyAdoptionRate">
        /// Percentage of assigned seats with activity in the 30-day rolling window (`MAU / assigned_seat_count * 100`). Null when the response is scoped to an RBAC group.
        /// </param>
        /// <param name="officeAgentDailyActiveUserCount">
        /// Number of users with Claude in Office activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="officeAgentMonthlyActiveUserCount">
        /// Number of users with Claude in Office activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="officeAgentWeeklyActiveUserCount">
        /// Number of users with Claude in Office activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="pendingInviteCount">
        /// Number of pending invitations to join the organization. Null when the response is scoped to an RBAC group.
        /// </param>
        /// <param name="scienceDailyActiveUserCount">
        /// Number of users with Claude Science activity on the requested day. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="scienceEntitledUserCount">
        /// Number of users with a Claude Science seat entitlement (per-seat RBAC) at the time of the daily snapshot. The funnel top; independent of the org-level Claude Science toggle. Null when the response is scoped to an RBAC group — entitlement is org-wide and has no per-group analogue. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="scienceMonthlyActiveUserCount">
        /// Number of users with Claude Science activity in the 30-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="scienceWeeklyActiveUserCount">
        /// Number of users with Claude Science activity in the 7-day rolling window. Omitted from the response while the per-product breakdown is not enabled for this organization.
        /// </param>
        /// <param name="weeklyAdoptionRate">
        /// Percentage of assigned seats with activity in the 7-day rolling window (`WAU / assigned_seat_count * 100`). Null when the response is scoped to an RBAC group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsSingleDayActivitySummary(
            int coworkDailyActiveUserCount,
            int coworkMonthlyActiveUserCount,
            int coworkWeeklyActiveUserCount,
            int dailyActiveUserCount,
            global::System.DateTime endingAt,
            int monthlyActiveUserCount,
            global::System.DateTime startingAt,
            int weeklyActiveUserCount,
            int? assignedSeatCount,
            int? chatDailyActiveUserCount,
            int? chatMonthlyActiveUserCount,
            int? chatWeeklyActiveUserCount,
            int? claudeCodeDailyActiveUserCount,
            int? claudeCodeMonthlyActiveUserCount,
            int? claudeCodeWeeklyActiveUserCount,
            int? claudeDesignDailyActiveUserCount,
            int? claudeDesignMonthlyActiveUserCount,
            int? claudeDesignWeeklyActiveUserCount,
            double? dailyAdoptionRate,
            double? monthlyAdoptionRate,
            int? officeAgentDailyActiveUserCount,
            int? officeAgentMonthlyActiveUserCount,
            int? officeAgentWeeklyActiveUserCount,
            int? pendingInviteCount,
            int? scienceDailyActiveUserCount,
            int? scienceEntitledUserCount,
            int? scienceMonthlyActiveUserCount,
            int? scienceWeeklyActiveUserCount,
            double? weeklyAdoptionRate)
        {
            this.AssignedSeatCount = assignedSeatCount;
            this.ChatDailyActiveUserCount = chatDailyActiveUserCount;
            this.ChatMonthlyActiveUserCount = chatMonthlyActiveUserCount;
            this.ChatWeeklyActiveUserCount = chatWeeklyActiveUserCount;
            this.ClaudeCodeDailyActiveUserCount = claudeCodeDailyActiveUserCount;
            this.ClaudeCodeMonthlyActiveUserCount = claudeCodeMonthlyActiveUserCount;
            this.ClaudeCodeWeeklyActiveUserCount = claudeCodeWeeklyActiveUserCount;
            this.ClaudeDesignDailyActiveUserCount = claudeDesignDailyActiveUserCount;
            this.ClaudeDesignMonthlyActiveUserCount = claudeDesignMonthlyActiveUserCount;
            this.ClaudeDesignWeeklyActiveUserCount = claudeDesignWeeklyActiveUserCount;
            this.CoworkDailyActiveUserCount = coworkDailyActiveUserCount;
            this.CoworkMonthlyActiveUserCount = coworkMonthlyActiveUserCount;
            this.CoworkWeeklyActiveUserCount = coworkWeeklyActiveUserCount;
            this.DailyActiveUserCount = dailyActiveUserCount;
            this.DailyAdoptionRate = dailyAdoptionRate;
            this.EndingAt = endingAt;
            this.MonthlyActiveUserCount = monthlyActiveUserCount;
            this.MonthlyAdoptionRate = monthlyAdoptionRate;
            this.OfficeAgentDailyActiveUserCount = officeAgentDailyActiveUserCount;
            this.OfficeAgentMonthlyActiveUserCount = officeAgentMonthlyActiveUserCount;
            this.OfficeAgentWeeklyActiveUserCount = officeAgentWeeklyActiveUserCount;
            this.PendingInviteCount = pendingInviteCount;
            this.ScienceDailyActiveUserCount = scienceDailyActiveUserCount;
            this.ScienceEntitledUserCount = scienceEntitledUserCount;
            this.ScienceMonthlyActiveUserCount = scienceMonthlyActiveUserCount;
            this.ScienceWeeklyActiveUserCount = scienceWeeklyActiveUserCount;
            this.StartingAt = startingAt;
            this.WeeklyActiveUserCount = weeklyActiveUserCount;
            this.WeeklyAdoptionRate = weeklyAdoptionRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSingleDayActivitySummary" /> class.
        /// </summary>
        public BetaAnalyticsSingleDayActivitySummary()
        {
        }

    }
}