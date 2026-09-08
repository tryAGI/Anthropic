
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-plugin install + invocation activity for a given day.<br/>
    /// With `group_by[]=user_id` / `rbac_group_id` / `product` (`cowork` /<br/>
    /// `claude_code` only on this endpoint) each row is one (plugin, user),<br/>
    /// (plugin, group), or (plugin, product) cut: the flat `user_id` /<br/>
    /// `rbac_group_id` / `product` keys carry the cut and the counts are<br/>
    /// scoped to it.
    /// </summary>
    public sealed partial class BetaAnalyticsPluginActivity
    {
        /// <summary>
        /// Claude Code activity metrics for a single plugin on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsPluginClaudeCodeMetrics ClaudeCodeMetrics { get; set; }

        /// <summary>
        /// Cowork activity metrics for a single plugin on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cowork_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsPluginCoworkMetrics CoworkMetrics { get; set; }

        /// <summary>
        /// Number of distinct users with recorded install or invocation activity for the plugin on the requested day (install-only users count), or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctUserCount { get; set; }

        /// <summary>
        /// Number of distinct users who installed the plugin on the requested day, or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("install_count")]
        public int? InstallCount { get; set; }

        /// <summary>
        /// Number of plugin invocations on the requested day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InvocationCount { get; set; }

        /// <summary>
        /// Stable plugin identifier when available (e.g. `serena@claude-plugins-official`). Null for third-party Claude Code plugins (redacted at the source) and Cowork slash commands that carry only a hashed id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        public string? PluginId { get; set; }

        /// <summary>
        /// Name of the plugin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginName { get; set; }

        /// <summary>
        /// Product that produced this row's activity: one of `chat`, `claude_code`, `cowork`, or `office_agent` (the canonical Cost &amp; Usage product naming; an `office_agent` row's per-surface breakdown is in its `office_metrics`). On `/plugins` only `cowork` and `claude_code` occur (the only surfaces with plugin attribution); on `/artifacts` only `chat`, `claude_code`, and `cowork` occur (the surfaces that create artifacts); `/apps/chat/projects` does not support the product dimension (a `product` entry in `group_by[]` or `filter[]` there is rejected). Present only when the request grouped by `product`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// Tagged RBAC group identifier (`rbac_group_...`), matching the spend-limits API spelling. Present only when the request grouped by `rbac_group_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        public string? RbacGroupId { get; set; }

        /// <summary>
        /// Resolved RBAC group display name, alongside `rbac_group_id` when name resolution is available. Null if the group has been deleted or its name could not be resolved; `rbac_group_id` remains the stable key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_name")]
        public string? RbacGroupName { get; set; }

        /// <summary>
        /// Tagged user identifier (e.g. `user_...`). Present only when the request grouped by `user_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginActivity" /> class.
        /// </summary>
        /// <param name="claudeCodeMetrics">
        /// Claude Code activity metrics for a single plugin on a given day.
        /// </param>
        /// <param name="coworkMetrics">
        /// Cowork activity metrics for a single plugin on a given day.
        /// </param>
        /// <param name="distinctUserCount">
        /// Number of distinct users with recorded install or invocation activity for the plugin on the requested day (install-only users count), or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values.
        /// </param>
        /// <param name="invocationCount">
        /// Number of plugin invocations on the requested day
        /// </param>
        /// <param name="pluginName">
        /// Name of the plugin
        /// </param>
        /// <param name="installCount">
        /// Number of distinct users who installed the plugin on the requested day, or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values.
        /// </param>
        /// <param name="pluginId">
        /// Stable plugin identifier when available (e.g. `serena@claude-plugins-official`). Null for third-party Claude Code plugins (redacted at the source) and Cowork slash commands that carry only a hashed id.
        /// </param>
        /// <param name="product">
        /// Product that produced this row's activity: one of `chat`, `claude_code`, `cowork`, or `office_agent` (the canonical Cost &amp; Usage product naming; an `office_agent` row's per-surface breakdown is in its `office_metrics`). On `/plugins` only `cowork` and `claude_code` occur (the only surfaces with plugin attribution); on `/artifacts` only `chat`, `claude_code`, and `cowork` occur (the surfaces that create artifacts); `/apps/chat/projects` does not support the product dimension (a `product` entry in `group_by[]` or `filter[]` there is rejected). Present only when the request grouped by `product`.
        /// </param>
        /// <param name="rbacGroupId">
        /// Tagged RBAC group identifier (`rbac_group_...`), matching the spend-limits API spelling. Present only when the request grouped by `rbac_group_id`.
        /// </param>
        /// <param name="rbacGroupName">
        /// Resolved RBAC group display name, alongside `rbac_group_id` when name resolution is available. Null if the group has been deleted or its name could not be resolved; `rbac_group_id` remains the stable key.
        /// </param>
        /// <param name="userId">
        /// Tagged user identifier (e.g. `user_...`). Present only when the request grouped by `user_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsPluginActivity(
            global::Anthropic.BetaAnalyticsPluginClaudeCodeMetrics claudeCodeMetrics,
            global::Anthropic.BetaAnalyticsPluginCoworkMetrics coworkMetrics,
            int distinctUserCount,
            int invocationCount,
            string pluginName,
            int? installCount,
            string? pluginId,
            string? product,
            string? rbacGroupId,
            string? rbacGroupName,
            string? userId)
        {
            this.ClaudeCodeMetrics = claudeCodeMetrics ?? throw new global::System.ArgumentNullException(nameof(claudeCodeMetrics));
            this.CoworkMetrics = coworkMetrics ?? throw new global::System.ArgumentNullException(nameof(coworkMetrics));
            this.DistinctUserCount = distinctUserCount;
            this.InstallCount = installCount;
            this.InvocationCount = invocationCount;
            this.PluginId = pluginId;
            this.PluginName = pluginName ?? throw new global::System.ArgumentNullException(nameof(pluginName));
            this.Product = product;
            this.RbacGroupId = rbacGroupId;
            this.RbacGroupName = rbacGroupName;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginActivity" /> class.
        /// </summary>
        public BetaAnalyticsPluginActivity()
        {
        }

    }
}