
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeUsageReportItem
    {
        /// <summary>
        /// The user or API key that performed the Claude Code actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ActorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Actor Actor { get; set; }

        /// <summary>
        /// Core productivity metrics measuring Claude Code usage and impact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCoreMetrics CoreMetrics { get; set; }

        /// <summary>
        /// Type of customer account (api for API customers, subscription for Pro/Team customers).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaCustomerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCustomerType CustomerType { get; set; }

        /// <summary>
        /// UTC day the usage metrics cover, as an RFC 3339 timestamp at midnight UTC<br/>
        /// (for example `2025-08-08T00:00:00Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Whether the usage came from remote Claude Code sessions, such as Claude Code<br/>
        /// on the web. Remote and local usage are reported as separate rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_remote")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRemote { get; set; }

        /// <summary>
        /// Token usage and cost breakdown by AI model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaModelBreakdown> ModelBreakdown { get; set; }

        /// <summary>
        /// ID of the organization that owns the Claude Code usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Subscription tier for subscription customers. `null` for API customers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_type")]
        public global::Anthropic.BetaSubscriptionType? SubscriptionType { get; set; }

        /// <summary>
        /// Type of terminal or environment where Claude Code was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminal_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TerminalType { get; set; }

        /// <summary>
        /// Breakdown of tool action acceptance and rejection rates by tool type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaApprovalMetrics> ToolActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeUsageReportItem" /> class.
        /// </summary>
        /// <param name="actor">
        /// The user or API key that performed the Claude Code actions.
        /// </param>
        /// <param name="coreMetrics">
        /// Core productivity metrics measuring Claude Code usage and impact.
        /// </param>
        /// <param name="customerType">
        /// Type of customer account (api for API customers, subscription for Pro/Team customers).
        /// </param>
        /// <param name="date">
        /// UTC day the usage metrics cover, as an RFC 3339 timestamp at midnight UTC<br/>
        /// (for example `2025-08-08T00:00:00Z`).
        /// </param>
        /// <param name="isRemote">
        /// Whether the usage came from remote Claude Code sessions, such as Claude Code<br/>
        /// on the web. Remote and local usage are reported as separate rows.
        /// </param>
        /// <param name="modelBreakdown">
        /// Token usage and cost breakdown by AI model used.
        /// </param>
        /// <param name="organizationId">
        /// ID of the organization that owns the Claude Code usage.
        /// </param>
        /// <param name="terminalType">
        /// Type of terminal or environment where Claude Code was used.
        /// </param>
        /// <param name="toolActions">
        /// Breakdown of tool action acceptance and rejection rates by tool type.
        /// </param>
        /// <param name="subscriptionType">
        /// Subscription tier for subscription customers. `null` for API customers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeUsageReportItem(
            global::Anthropic.Actor actor,
            global::Anthropic.BetaCoreMetrics coreMetrics,
            global::Anthropic.BetaCustomerType customerType,
            global::System.DateTime date,
            bool isRemote,
            global::System.Collections.Generic.IList<global::Anthropic.BetaModelBreakdown> modelBreakdown,
            string organizationId,
            string terminalType,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaApprovalMetrics> toolActions,
            global::Anthropic.BetaSubscriptionType? subscriptionType)
        {
            this.Actor = actor;
            this.CoreMetrics = coreMetrics ?? throw new global::System.ArgumentNullException(nameof(coreMetrics));
            this.CustomerType = customerType;
            this.Date = date;
            this.IsRemote = isRemote;
            this.ModelBreakdown = modelBreakdown ?? throw new global::System.ArgumentNullException(nameof(modelBreakdown));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.SubscriptionType = subscriptionType;
            this.TerminalType = terminalType ?? throw new global::System.ArgumentNullException(nameof(terminalType));
            this.ToolActions = toolActions ?? throw new global::System.ArgumentNullException(nameof(toolActions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeUsageReportItem" /> class.
        /// </summary>
        public BetaClaudeCodeUsageReportItem()
        {
        }

    }
}