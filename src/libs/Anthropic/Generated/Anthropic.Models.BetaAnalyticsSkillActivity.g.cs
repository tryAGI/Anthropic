
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-skill activity data for a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsSkillActivity
    {
        /// <summary>
        /// List-price (rate-card) value of the member requests attributed to this skill, as a decimal string in the minor unit of `currency` (cents for USD), from Claude Code, Cowork, and Office Agent request-level attribution — the value of requests that involved the skill, not the skill's incremental cost. Unlike `estimated_overage_spend` this reflects usage value regardless of how it was funded — seat-covered usage counts — but it is undiscounted and does not tie to billed spend or the organization's spend reporting. claude.ai chat usage carries no request-level attribution and contributes nothing: the field is null on `chat` product rows and on `office_agent` product cuts dated before 2026-06-18 (the Office Agent attribution data-start), and on ungrouped rows it covers the Claude Code + Cowork + Office Agent share only (null when no attributable usage exists). Also null under the same conditions as `estimated_overage_spend` (spend reporting not enabled for this organization, `office_agent` product cuts before the 2026-06-18 data-start). "0" means attributable usage existed but none was attributed to this skill. Addable across days: date-range rollup mode returns the window's sum. On `group_by[]` and `filter[]` shapes both amounts can total below the ungrouped value for the same skill over the same date or range: spend attributed to a member–skill pair with no counted usage on that day is excluded from those cuts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributed_list_price")]
        public string? AttributedListPrice { get; set; }

        /// <summary>
        /// Claude.ai activity metrics for a single skill on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsSkillChatMetrics ChatMetrics { get; set; }

        /// <summary>
        /// Claude Code activity metrics for a single skill on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsSkillClaudeCodeMetrics ClaudeCodeMetrics { get; set; }

        /// <summary>
        /// Cowork activity metrics for a single skill on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cowork_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsSkillCoworkMetrics CoworkMetrics { get; set; }

        /// <summary>
        /// Currency for this row's monetary fields (`estimated_overage_spend` and `attributed_list_price`), as an uppercase ISO-4217 code. Always "USD" when either amount is populated; null whenever both amounts are null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Number of distinct users who used the skill on the requested day, or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values. A skill counts as used only when it is explicitly activated — the model (or the user, via the skill's slash command) invokes it, reading its instructions into context as part of that activation. Skills that are merely installed or listed as available, or whose content reaches the context without an activation (preloaded, hook-injected, or read as a plain file), are not counted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctUserCount { get; set; }

        /// <summary>
        /// Distinct accounts that enabled this skill on the requested day (claude.ai only — the skill analog of plugin `install_count`). The count is org-wide: null when enable reporting is not enabled for this organization, or when the request scopes to `user_id` / `rbac_group_id` / `product` via `group_by[]` or `filter[]` (an org-wide count would be misleading on per-cut rows). A distinct count, not an event count: summing across days double-counts members who enable the skill on more than one day, so it is also null in date-range rollup mode (`starting_date`/`ending_date`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_count")]
        public int? EnableCount { get; set; }

        /// <summary>
        /// Estimated overage spend attributed to this skill, as a decimal string in the minor unit of `currency` (cents for USD; "1250" is $12.50, fractional cents possible) — an allocation of each member's daily post-discount, pre-credit metered overage spend (the same cost basis as the organization's spend reporting and the Cost &amp; Usage API, so per-skill figures are directly comparable; spend with no skill attribution — including any member-day without skill invocations — is not represented, so skill rows sum to at most those totals) across the skills the member used. Overage only: usage covered by included seat allowances bills nothing and allocates $0 here — see `attributed_list_price` for the funding-independent usage-value companion. Claude Code, Cowork, and Office Agent spend use request-level skill attribution; claude.ai chat spend is approximated proportionally to skill-invoking messages. An estimate, not a billing number — and the cost of the requests/messages that involved the skill, not the skill's incremental cost (the same request would still have cost something without the skill active). "0" means no overage spend was attributed; null when spend reporting is not enabled for this organization, on `office_agent` product cuts dated before 2026-06-18 (the Office Agent attribution data-start). Addable across days: date-range rollup mode (`starting_date`/`ending_date`) returns the window's sum. With `group_by[]=user_id` each row carries the user's own attributed spend. On `group_by[]` and `filter[]` shapes both amounts can total below the ungrouped value for the same skill over the same date or range: spend attributed to a member–skill pair with no counted usage on that day is excluded from those cuts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_overage_spend")]
        public string? EstimatedOverageSpend { get; set; }

        /// <summary>
        /// Total number of times this skill was invoked on the requested day (the skill analog of plugin `invocation_count`). Unlike `distinct_user_count` — which answers '# of users' — this is the true '# of uses'. A skill counts as used only when it is explicitly activated — the model (or the user, via the skill's slash command) invokes it, reading its instructions into context as part of that activation. Skills that are merely installed or listed as available, or whose content reaches the context without an activation (preloaded, hook-injected, or read as a plain file), are not counted. Null when invocation reporting is not enabled for this organization. Sum across a date range for total uses in the window — date-range rollup mode (`starting_date`/`ending_date`) returns this sum directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_count")]
        public int? InvocationCount { get; set; }

        /// <summary>
        /// Office Agent activity metrics for a single skill on a given day, broken out by Office product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("office_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsSkillOfficeMetrics OfficeMetrics { get; set; }

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
        /// Skill share status (claude.ai only): one of `private`, `organization`, or `public`. Null for skills used only in Claude Code or Office (no per-skill share-status concept) and when share-status reporting is not yet available for the organization. Filterable via `filter[]=share_status:{value}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_status")]
        public global::Anthropic.BetaAnalyticsSkillActivityShareStatus? ShareStatus { get; set; }

        /// <summary>
        /// Human-readable display name for rows whose `skill_name` is an opaque skill id (user/organization skill types and plugin-delivered skills — user-defined names are withheld from the analytics pipeline). Organization-shared skills and skills delivered by the organization's own plugins (its plugin marketplaces and its library) resolve; plugin skill names are shown without their 'plugin:' prefix. The literal 'unknown' bucket row gets a fixed 'Unknown skill' label. Null for private (user-defined) skills and members' personal-plugin skills — those names are not disclosed to analytics-key holders — and for Anthropic-provided plugin skills (not resolved), and null when `skill_name` is already a display name, when the skill or plugin was deleted, or when display-name resolution is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_display_name")]
        public string? SkillDisplayName { get; set; }

        /// <summary>
        /// Name of the skill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillName { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillActivity" /> class.
        /// </summary>
        /// <param name="chatMetrics">
        /// Claude.ai activity metrics for a single skill on a given day.
        /// </param>
        /// <param name="claudeCodeMetrics">
        /// Claude Code activity metrics for a single skill on a given day.
        /// </param>
        /// <param name="coworkMetrics">
        /// Cowork activity metrics for a single skill on a given day.
        /// </param>
        /// <param name="distinctUserCount">
        /// Number of distinct users who used the skill on the requested day, or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values. A skill counts as used only when it is explicitly activated — the model (or the user, via the skill's slash command) invokes it, reading its instructions into context as part of that activation. Skills that are merely installed or listed as available, or whose content reaches the context without an activation (preloaded, hook-injected, or read as a plain file), are not counted.
        /// </param>
        /// <param name="officeMetrics">
        /// Office Agent activity metrics for a single skill on a given day, broken out by Office product.
        /// </param>
        /// <param name="skillName">
        /// Name of the skill
        /// </param>
        /// <param name="attributedListPrice">
        /// List-price (rate-card) value of the member requests attributed to this skill, as a decimal string in the minor unit of `currency` (cents for USD), from Claude Code, Cowork, and Office Agent request-level attribution — the value of requests that involved the skill, not the skill's incremental cost. Unlike `estimated_overage_spend` this reflects usage value regardless of how it was funded — seat-covered usage counts — but it is undiscounted and does not tie to billed spend or the organization's spend reporting. claude.ai chat usage carries no request-level attribution and contributes nothing: the field is null on `chat` product rows and on `office_agent` product cuts dated before 2026-06-18 (the Office Agent attribution data-start), and on ungrouped rows it covers the Claude Code + Cowork + Office Agent share only (null when no attributable usage exists). Also null under the same conditions as `estimated_overage_spend` (spend reporting not enabled for this organization, `office_agent` product cuts before the 2026-06-18 data-start). "0" means attributable usage existed but none was attributed to this skill. Addable across days: date-range rollup mode returns the window's sum. On `group_by[]` and `filter[]` shapes both amounts can total below the ungrouped value for the same skill over the same date or range: spend attributed to a member–skill pair with no counted usage on that day is excluded from those cuts.
        /// </param>
        /// <param name="currency">
        /// Currency for this row's monetary fields (`estimated_overage_spend` and `attributed_list_price`), as an uppercase ISO-4217 code. Always "USD" when either amount is populated; null whenever both amounts are null.
        /// </param>
        /// <param name="enableCount">
        /// Distinct accounts that enabled this skill on the requested day (claude.ai only — the skill analog of plugin `install_count`). The count is org-wide: null when enable reporting is not enabled for this organization, or when the request scopes to `user_id` / `rbac_group_id` / `product` via `group_by[]` or `filter[]` (an org-wide count would be misleading on per-cut rows). A distinct count, not an event count: summing across days double-counts members who enable the skill on more than one day, so it is also null in date-range rollup mode (`starting_date`/`ending_date`).
        /// </param>
        /// <param name="estimatedOverageSpend">
        /// Estimated overage spend attributed to this skill, as a decimal string in the minor unit of `currency` (cents for USD; "1250" is $12.50, fractional cents possible) — an allocation of each member's daily post-discount, pre-credit metered overage spend (the same cost basis as the organization's spend reporting and the Cost &amp; Usage API, so per-skill figures are directly comparable; spend with no skill attribution — including any member-day without skill invocations — is not represented, so skill rows sum to at most those totals) across the skills the member used. Overage only: usage covered by included seat allowances bills nothing and allocates $0 here — see `attributed_list_price` for the funding-independent usage-value companion. Claude Code, Cowork, and Office Agent spend use request-level skill attribution; claude.ai chat spend is approximated proportionally to skill-invoking messages. An estimate, not a billing number — and the cost of the requests/messages that involved the skill, not the skill's incremental cost (the same request would still have cost something without the skill active). "0" means no overage spend was attributed; null when spend reporting is not enabled for this organization, on `office_agent` product cuts dated before 2026-06-18 (the Office Agent attribution data-start). Addable across days: date-range rollup mode (`starting_date`/`ending_date`) returns the window's sum. With `group_by[]=user_id` each row carries the user's own attributed spend. On `group_by[]` and `filter[]` shapes both amounts can total below the ungrouped value for the same skill over the same date or range: spend attributed to a member–skill pair with no counted usage on that day is excluded from those cuts.
        /// </param>
        /// <param name="invocationCount">
        /// Total number of times this skill was invoked on the requested day (the skill analog of plugin `invocation_count`). Unlike `distinct_user_count` — which answers '# of users' — this is the true '# of uses'. A skill counts as used only when it is explicitly activated — the model (or the user, via the skill's slash command) invokes it, reading its instructions into context as part of that activation. Skills that are merely installed or listed as available, or whose content reaches the context without an activation (preloaded, hook-injected, or read as a plain file), are not counted. Null when invocation reporting is not enabled for this organization. Sum across a date range for total uses in the window — date-range rollup mode (`starting_date`/`ending_date`) returns this sum directly.
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
        /// <param name="shareStatus">
        /// Skill share status (claude.ai only): one of `private`, `organization`, or `public`. Null for skills used only in Claude Code or Office (no per-skill share-status concept) and when share-status reporting is not yet available for the organization. Filterable via `filter[]=share_status:{value}`.
        /// </param>
        /// <param name="skillDisplayName">
        /// Human-readable display name for rows whose `skill_name` is an opaque skill id (user/organization skill types and plugin-delivered skills — user-defined names are withheld from the analytics pipeline). Organization-shared skills and skills delivered by the organization's own plugins (its plugin marketplaces and its library) resolve; plugin skill names are shown without their 'plugin:' prefix. The literal 'unknown' bucket row gets a fixed 'Unknown skill' label. Null for private (user-defined) skills and members' personal-plugin skills — those names are not disclosed to analytics-key holders — and for Anthropic-provided plugin skills (not resolved), and null when `skill_name` is already a display name, when the skill or plugin was deleted, or when display-name resolution is not enabled for this organization.
        /// </param>
        /// <param name="userId">
        /// Tagged user identifier (e.g. `user_...`). Present only when the request grouped by `user_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsSkillActivity(
            global::Anthropic.BetaAnalyticsSkillChatMetrics chatMetrics,
            global::Anthropic.BetaAnalyticsSkillClaudeCodeMetrics claudeCodeMetrics,
            global::Anthropic.BetaAnalyticsSkillCoworkMetrics coworkMetrics,
            int distinctUserCount,
            global::Anthropic.BetaAnalyticsSkillOfficeMetrics officeMetrics,
            string skillName,
            string? attributedListPrice,
            string? currency,
            int? enableCount,
            string? estimatedOverageSpend,
            int? invocationCount,
            string? product,
            string? rbacGroupId,
            string? rbacGroupName,
            global::Anthropic.BetaAnalyticsSkillActivityShareStatus? shareStatus,
            string? skillDisplayName,
            string? userId)
        {
            this.AttributedListPrice = attributedListPrice;
            this.ChatMetrics = chatMetrics ?? throw new global::System.ArgumentNullException(nameof(chatMetrics));
            this.ClaudeCodeMetrics = claudeCodeMetrics ?? throw new global::System.ArgumentNullException(nameof(claudeCodeMetrics));
            this.CoworkMetrics = coworkMetrics ?? throw new global::System.ArgumentNullException(nameof(coworkMetrics));
            this.Currency = currency;
            this.DistinctUserCount = distinctUserCount;
            this.EnableCount = enableCount;
            this.EstimatedOverageSpend = estimatedOverageSpend;
            this.InvocationCount = invocationCount;
            this.OfficeMetrics = officeMetrics ?? throw new global::System.ArgumentNullException(nameof(officeMetrics));
            this.Product = product;
            this.RbacGroupId = rbacGroupId;
            this.RbacGroupName = rbacGroupName;
            this.ShareStatus = shareStatus;
            this.SkillDisplayName = skillDisplayName;
            this.SkillName = skillName ?? throw new global::System.ArgumentNullException(nameof(skillName));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillActivity" /> class.
        /// </summary>
        public BetaAnalyticsSkillActivity()
        {
        }

    }
}