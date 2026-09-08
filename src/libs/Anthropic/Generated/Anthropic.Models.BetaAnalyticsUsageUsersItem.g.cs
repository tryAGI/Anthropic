
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsUsageUsersItem
    {
        /// <summary>
        /// The user this row's usage or cost is attributed to. Always a `user_actor`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsUserActor Actor { get; set; }

        /// <summary>
        /// The number of input tokens for cache creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCacheCreation CacheCreation { get; set; }

        /// <summary>
        /// The number of input tokens read from the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheReadInputTokens { get; set; }

        /// <summary>
        /// Claude Tag (Claude in Slack) spend category: `engaged` (a person addressed Claude in a channel or thread), `proactive` (Claude responded without being addressed), `scheduled` (a scheduled routine ran), `monitoring` (Claude watching a channel it was asked to monitor), or `dm` (direct messages with Claude). Populated only when `claude_tag_category` is in `group_by[]`; null for usage that is not Claude Tag. Direct-message usage is billed to the individual user and is reported under that user's product, not under `claude-tag`. New categories may be added over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_tag_category")]
        public global::Anthropic.BetaAnalyticsClaudeTagCategory? ClaudeTagCategory { get; set; }

        /// <summary>
        /// Slack user ID (for example `U0123ABCDEF`) of the member the Claude Tag (Claude in Slack) usage is attributed to, not a claude.ai user ID. Populated only when `claude_tag_user_id` is in `group_by[]`; null for usage that is not Claude Tag and for Claude Tag usage that is not attributed to a single user (for example `monitoring`, and `proactive` usage Claude initiated), so per-user rows can sum to less than the Claude Tag total. Cannot be combined with `group_by[]=rbac_group_id` or the `rbac_group_ids[]` filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_tag_user_id")]
        public string? ClaudeTagUserId { get; set; }

        /// <summary>
        /// Context-window pricing tier of the usage or cost. Null unless `context_window` is in `group_by[]`; it can also be null on grouped rows with no context-window tier, such as code execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        public global::Anthropic.BetaMessagesUsageReportContextWindow? ContextWindow { get; set; }

        /// <summary>
        /// End of the row's UTC time bucket (exclusive), as an RFC 3339 timestamp; equal to `starting_at` plus one `bucket_width`. Null unless `bucket_width` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        public global::System.DateTime? EndingAt { get; set; }

        /// <summary>
        /// Inference region of the usage or cost. Null unless `inference_geo` is in `group_by[]`; it can also be null on grouped rows where the region is not set (the rows that `inference_geos[]=not_available` matches).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        public global::Anthropic.BetaInferenceGeo? InferenceGeo { get; set; }

        /// <summary>
        /// Model that produced the usage or cost, as a model name in the form the `models[]` filter accepts (for example, `claude-opus-5`). Null unless `model` is in `group_by[]`; it can also be null on grouped rows whose usage or cost is not attributed to a specific model, such as code execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The number of output tokens generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Product surface that produced the usage or cost. Null unless product is in `group_by[]`; it can also be null on grouped rows whose usage cannot be attributed to a known surface. Values include `chat`, `claude_code`, `cowork`, `office_agent`, `claude_in_chrome`, `claude_design`, and `claude-tag`. `claude-tag` is Claude Tag, the Claude product in Slack. Some unattributed usage is reported as "other".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// RBAC group (team) the usage is attributed to, in the public tagged `rbac_group_...` spelling — the same spelling the activity resources use for this key, so the same team has one id across resources and it round-trips as an `rbac_group_ids[]` filter value. Populated only when `rbac_group_id` is in `group_by[]`. Any-membership semantics: a user in several groups contributes their full usage to each of those groups' rows, so the named-group rows overlap and their sum can exceed the org total. A null value is the single unassigned row: users in no group on that (UTC) day. For the true org total, run the same query without `group_by[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        public string? RbacGroupId { get; set; }

        /// <summary>
        /// Number of API requests in this row's scope. For sandbox / code-execution events, this counts execution spans rather than HTTP requests (these rows surface with `product: null`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Server-side tool usage metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaServerToolUse ServerToolUse { get; set; }

        /// <summary>
        /// Slack channel the usage originated from. Populated only when `slack_channel_id` is in `group_by[]`; null for usage outside Slack (and for rows recorded before channel attribution was enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_channel_id")]
        public string? SlackChannelId { get; set; }

        /// <summary>
        /// Inference speed mode of the usage or cost: `fast` or `standard`. Null unless `speed` is in `group_by[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public global::Anthropic.BetaAnalyticsUsageUsersItemSpeed? Speed { get; set; }

        /// <summary>
        /// Start of the row's UTC time bucket (inclusive), as an RFC 3339 timestamp. Null unless `bucket_width` is set; without `bucket_width`, each row aggregates the full requested range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_at")]
        public global::System.DateTime? StartingAt { get; set; }

        /// <summary>
        /// Total token count across all token types. This is the value the default `order_by` (`total_tokens`) sorts on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// The number of uncached input tokens processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UncachedInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUsageUsersItem" /> class.
        /// </summary>
        /// <param name="actor">
        /// The user this row's usage or cost is attributed to. Always a `user_actor`.
        /// </param>
        /// <param name="cacheCreation">
        /// The number of input tokens for cache creation.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The number of input tokens read from the cache.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens generated.
        /// </param>
        /// <param name="serverToolUse">
        /// Server-side tool usage metrics.
        /// </param>
        /// <param name="totalTokens">
        /// Total token count across all token types. This is the value the default `order_by` (`total_tokens`) sorts on.
        /// </param>
        /// <param name="uncachedInputTokens">
        /// The number of uncached input tokens processed.
        /// </param>
        /// <param name="claudeTagCategory">
        /// Claude Tag (Claude in Slack) spend category: `engaged` (a person addressed Claude in a channel or thread), `proactive` (Claude responded without being addressed), `scheduled` (a scheduled routine ran), `monitoring` (Claude watching a channel it was asked to monitor), or `dm` (direct messages with Claude). Populated only when `claude_tag_category` is in `group_by[]`; null for usage that is not Claude Tag. Direct-message usage is billed to the individual user and is reported under that user's product, not under `claude-tag`. New categories may be added over time.
        /// </param>
        /// <param name="claudeTagUserId">
        /// Slack user ID (for example `U0123ABCDEF`) of the member the Claude Tag (Claude in Slack) usage is attributed to, not a claude.ai user ID. Populated only when `claude_tag_user_id` is in `group_by[]`; null for usage that is not Claude Tag and for Claude Tag usage that is not attributed to a single user (for example `monitoring`, and `proactive` usage Claude initiated), so per-user rows can sum to less than the Claude Tag total. Cannot be combined with `group_by[]=rbac_group_id` or the `rbac_group_ids[]` filter.
        /// </param>
        /// <param name="contextWindow">
        /// Context-window pricing tier of the usage or cost. Null unless `context_window` is in `group_by[]`; it can also be null on grouped rows with no context-window tier, such as code execution.
        /// </param>
        /// <param name="endingAt">
        /// End of the row's UTC time bucket (exclusive), as an RFC 3339 timestamp; equal to `starting_at` plus one `bucket_width`. Null unless `bucket_width` is set.
        /// </param>
        /// <param name="inferenceGeo">
        /// Inference region of the usage or cost. Null unless `inference_geo` is in `group_by[]`; it can also be null on grouped rows where the region is not set (the rows that `inference_geos[]=not_available` matches).
        /// </param>
        /// <param name="model">
        /// Model that produced the usage or cost, as a model name in the form the `models[]` filter accepts (for example, `claude-opus-5`). Null unless `model` is in `group_by[]`; it can also be null on grouped rows whose usage or cost is not attributed to a specific model, such as code execution.
        /// </param>
        /// <param name="product">
        /// Product surface that produced the usage or cost. Null unless product is in `group_by[]`; it can also be null on grouped rows whose usage cannot be attributed to a known surface. Values include `chat`, `claude_code`, `cowork`, `office_agent`, `claude_in_chrome`, `claude_design`, and `claude-tag`. `claude-tag` is Claude Tag, the Claude product in Slack. Some unattributed usage is reported as "other".
        /// </param>
        /// <param name="rbacGroupId">
        /// RBAC group (team) the usage is attributed to, in the public tagged `rbac_group_...` spelling — the same spelling the activity resources use for this key, so the same team has one id across resources and it round-trips as an `rbac_group_ids[]` filter value. Populated only when `rbac_group_id` is in `group_by[]`. Any-membership semantics: a user in several groups contributes their full usage to each of those groups' rows, so the named-group rows overlap and their sum can exceed the org total. A null value is the single unassigned row: users in no group on that (UTC) day. For the true org total, run the same query without `group_by[]`.
        /// </param>
        /// <param name="requests">
        /// Number of API requests in this row's scope. For sandbox / code-execution events, this counts execution spans rather than HTTP requests (these rows surface with `product: null`).
        /// </param>
        /// <param name="slackChannelId">
        /// Slack channel the usage originated from. Populated only when `slack_channel_id` is in `group_by[]`; null for usage outside Slack (and for rows recorded before channel attribution was enabled).
        /// </param>
        /// <param name="speed">
        /// Inference speed mode of the usage or cost: `fast` or `standard`. Null unless `speed` is in `group_by[]`.
        /// </param>
        /// <param name="startingAt">
        /// Start of the row's UTC time bucket (inclusive), as an RFC 3339 timestamp. Null unless `bucket_width` is set; without `bucket_width`, each row aggregates the full requested range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsUsageUsersItem(
            global::Anthropic.BetaAnalyticsUserActor actor,
            global::Anthropic.BetaCacheCreation cacheCreation,
            int cacheReadInputTokens,
            int outputTokens,
            global::Anthropic.BetaServerToolUse serverToolUse,
            int totalTokens,
            int uncachedInputTokens,
            global::Anthropic.BetaAnalyticsClaudeTagCategory? claudeTagCategory,
            string? claudeTagUserId,
            global::Anthropic.BetaMessagesUsageReportContextWindow? contextWindow,
            global::System.DateTime? endingAt,
            global::Anthropic.BetaInferenceGeo? inferenceGeo,
            string? model,
            string? product,
            string? rbacGroupId,
            int? requests,
            string? slackChannelId,
            global::Anthropic.BetaAnalyticsUsageUsersItemSpeed? speed,
            global::System.DateTime? startingAt)
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.CacheCreation = cacheCreation ?? throw new global::System.ArgumentNullException(nameof(cacheCreation));
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.ClaudeTagCategory = claudeTagCategory;
            this.ClaudeTagUserId = claudeTagUserId;
            this.ContextWindow = contextWindow;
            this.EndingAt = endingAt;
            this.InferenceGeo = inferenceGeo;
            this.Model = model;
            this.OutputTokens = outputTokens;
            this.Product = product;
            this.RbacGroupId = rbacGroupId;
            this.Requests = requests;
            this.ServerToolUse = serverToolUse ?? throw new global::System.ArgumentNullException(nameof(serverToolUse));
            this.SlackChannelId = slackChannelId;
            this.Speed = speed;
            this.StartingAt = startingAt;
            this.TotalTokens = totalTokens;
            this.UncachedInputTokens = uncachedInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUsageUsersItem" /> class.
        /// </summary>
        public BetaAnalyticsUsageUsersItem()
        {
        }

    }
}