#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Cost By Dimension<br/>
        /// Get cost in USD across a date range, broken out by dimension.<br/>
        /// Returns one row per combination of the requested `group_by[]`<br/>
        /// dimensions (and time bucket, when `time_bucket_width` is set) that has<br/>
        /// cost in the range, ranked by spend or ordered by time bucket; every<br/>
        /// combination is returned across pages. With no `group_by[]` and no<br/>
        /// `time_bucket_width`, a single row aggregates the whole range. Includes<br/>
        /// all cost, whether or not it is attributable to a seat user. Requires an<br/>
        /// API key with the `read:analytics` scope, or an Admin API key.
        /// </summary>
        /// <param name="startingAt">
        /// Start of range, inclusive. RFC 3339 tz-aware. Must be within the last 365 days and no earlier than 2026-01-01T00:00:00Z.
        /// </param>
        /// <param name="endingAt">
        /// End of range, exclusive. Required when `time_bucket_width` is set. Without `time_bucket_width`, defaults to the earlier of now and `starting_at` + 31 days. The range may span at most 31 days.
        /// </param>
        /// <param name="products">
        /// Product surfaces to include. Defaults to all products.
        /// </param>
        /// <param name="models">
        /// Models to include. Defaults to all models. Use `group_by[]=model` to break out per-model values.
        /// </param>
        /// <param name="contextWindows">
        /// Filter to specific context-window pricing tiers. Use `group_by[]=context_window` to break out per-tier values.
        /// </param>
        /// <param name="inferenceGeos">
        /// Filter to specific inference regions. `not_available` matches rows where the region is unset. Use `group_by[]=inference_geo` to break out per-region values.
        /// </param>
        /// <param name="speeds">
        /// Filter to fast or standard inference mode. Use `group_by[]=speed` to break out per-mode values.
        /// </param>
        /// <param name="slackChannelIds">
        /// Filter to usage originating from specific Slack channels. Use `group_by[]=slack_channel_id` to break out per-channel values.
        /// </param>
        /// <param name="claudeTagCategories">
        /// Filter to Claude Tag (Claude in Slack) usage in specific spend categories. Usage with no category never matches. `dm` usage is reported under the user's product rather than `claude_tag`, so combining this filter with `products[]=claude_tag` excludes it. Use `group_by[]=claude_tag_category` to break out per-category values.
        /// </param>
        /// <param name="claudeTagUserIds">
        /// Filter to Claude Tag (Claude in Slack) usage attributed to specific Slack users, by Slack user ID (for example `U0123ABCDEF`), not claude.ai user ID. Usage that is not Claude Tag, and Claude Tag usage not attributed to a single user, never matches. Use `group_by[]=claude_tag_user_id` to break out per-user values.
        /// </param>
        /// <param name="workspaceIds">
        /// Filter to usage in specific workspaces, by tagged workspace ID (`wrkspc_...`). Use `group_by[]=workspace_id` to break out per-workspace values. Claude Developer Platform organizations only; matches nothing for a Claude Enterprise organization.
        /// </param>
        /// <param name="serviceTiers">
        /// Filter to specific service tiers. Use `group_by[]=service_tier` to break out per-tier values. Claude Developer Platform organizations only; matches nothing for a Claude Enterprise organization.
        /// </param>
        /// <param name="rbacGroupIds">
        /// Filter to usage attributed to specific RBAC groups. Accepts tagged RBAC group IDs (`rbac_group_...`) or bare group UUIDs. A row matches when the user belonged to any of the listed groups on the (UTC) day the usage occurred; usage with no group attribution never matches.
        /// </param>
        /// <param name="userProfileIds">
        /// Filter to usage attributed to specific user profiles, by tagged user profile ID (`uprof_...`). Use `group_by[]=user_profile_id` to break out per-profile values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="agentIds">
        /// Filter to usage incurred by sessions of specific Claude Managed Agents agents. Use `group_by[]=agent_id` to break out per-agent values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="environmentIds">
        /// Filter to usage incurred by Claude Managed Agents sessions that ran in specific environments. Use `group_by[]=environment_id` to break out per-environment values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="deploymentIds">
        /// Filter to usage incurred by Claude Managed Agents sessions that specific deployments started. Use `group_by[]=deployment_id` to break out per-deployment values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="sessionIds">
        /// Filter to usage incurred by specific Claude Managed Agents sessions, by tagged session ID (`sesn_...`). Use `group_by[]=session_id` to break out per-session values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="actorIds">
        /// Filter to usage attributed to specific identities, by tagged ID: a `user_...`, `svac_...` (service account), or `apikey_...` ID. An `apikey_` entry matches only usage attributed to the key itself, not usage on that key attributed to a user or service account (use `api_key_ids[]` for every request a key authenticated). Federated identities have no tagged ID; select them with `actor_types[]`. Use `group_by[]=actor` to break out per-identity values.
        /// </param>
        /// <param name="actorTypes">
        /// Filter to usage attributed to specific kinds of identity. Use `group_by[]=actor_type` to break out per-kind values.
        /// </param>
        /// <param name="apiKeyIds">
        /// Filter to usage authenticated by specific API keys, by tagged API key ID (`apikey_...`), whichever identity the usage is attributed to. Include an empty entry (`api_key_ids[]=`) to also match usage that no API key authenticated. Use `group_by[]=api_key_id` to break out per-key values; usage without a key has a null `api_key_id`. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="timeBucketWidth">
        /// Time-bucket granularity. When set, rows are returned per time bucket (one per bucket and dimension combination with usage) and each row's `starting_at` and `ending_at` are that bucket's bounds; the time bucket counts toward `limit`. `ending_at` is required when `time_bucket_width` is set, and with `time_bucket_width="1m"` the range may span at most 24 hours. When omitted, each row aggregates the requested range with `starting_at` and `ending_at` each rounded down to the hour.
        /// </param>
        /// <param name="order">
        /// Sort direction of the `order_by` metric, or of the time buckets when `order_by` is `time` and `time_bucket_width` is set. Defaults to `desc`.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="excludeDeletedUsers">
        /// If true, omit rows whose `actor` is a `user_actor` with `deleted: true`. Requires `group_by[]=actor`. Rows for other actor types, and rows whose `actor` is null, are always kept. A page may contain fewer than `limit` rows; use `has_more` and `next_page` to paginate as usual.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Number of rows per page (1-1000, default 20). `cost_type`/`token_type` fan-out rows (cost endpoint only) do not count toward this limit, so `data` can exceed it.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="orderBy">
        /// Row order. A metric ranks rows by that metric in the `order` direction. `time` orders rows by time bucket in the `order` direction (newest first by default) and, within a bucket, by `amount`, highest first. `time` takes effect only with `time_bucket_width`; without it, `time` is the same as `amount`. Defaults to `amount`.<br/>
        /// Default Value: amount
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break cost out by (at most 5, not counting `cost_type` and `token_type`): one row per combination of their values with cost in the range (and per time bucket, when `time_bucket_width` is set), every combination returned across pages rather than a capped top set. `cost_type` and `token_type` do not count toward `limit`: `cost_type` returns one row per cost component (tokens, web search, code execution, and `session_usage`, Claude Managed Agents session time); `token_type` returns one row per token type, each with `cost_type: "tokens"`; combining both returns the per-token-type rows plus the web-search, code-execution and session-usage rows. When omitted, a single row aggregates the whole range.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `analytics-usage-cost-2026-08-24` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsFlatCostResponse> BetaGetCostV1OrganizationsAnalyticsCostGetAsync(
            global::System.DateTime startingAt,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? products = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? speeds = default,
            global::System.Collections.Generic.IList<string>? slackChannelIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories = default,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<string>? rbacGroupIds = default,
            global::System.Collections.Generic.IList<string>? userProfileIds = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? environmentIds = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<string>? sessionIds = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? actorTypes = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::Anthropic.BetaAnalyticsTimeBucketWidth? timeBucketWidth = default,
            global::Anthropic.BetaAnalyticsUsageCostSortOrder? order = default,
            bool? excludeDeletedUsers = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaAnalyticsFlatCostOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostGroupBy>? groupBy = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Cost By Dimension<br/>
        /// Get cost in USD across a date range, broken out by dimension.<br/>
        /// Returns one row per combination of the requested `group_by[]`<br/>
        /// dimensions (and time bucket, when `time_bucket_width` is set) that has<br/>
        /// cost in the range, ranked by spend or ordered by time bucket; every<br/>
        /// combination is returned across pages. With no `group_by[]` and no<br/>
        /// `time_bucket_width`, a single row aggregates the whole range. Includes<br/>
        /// all cost, whether or not it is attributable to a seat user. Requires an<br/>
        /// API key with the `read:analytics` scope, or an Admin API key.
        /// </summary>
        /// <param name="startingAt">
        /// Start of range, inclusive. RFC 3339 tz-aware. Must be within the last 365 days and no earlier than 2026-01-01T00:00:00Z.
        /// </param>
        /// <param name="endingAt">
        /// End of range, exclusive. Required when `time_bucket_width` is set. Without `time_bucket_width`, defaults to the earlier of now and `starting_at` + 31 days. The range may span at most 31 days.
        /// </param>
        /// <param name="products">
        /// Product surfaces to include. Defaults to all products.
        /// </param>
        /// <param name="models">
        /// Models to include. Defaults to all models. Use `group_by[]=model` to break out per-model values.
        /// </param>
        /// <param name="contextWindows">
        /// Filter to specific context-window pricing tiers. Use `group_by[]=context_window` to break out per-tier values.
        /// </param>
        /// <param name="inferenceGeos">
        /// Filter to specific inference regions. `not_available` matches rows where the region is unset. Use `group_by[]=inference_geo` to break out per-region values.
        /// </param>
        /// <param name="speeds">
        /// Filter to fast or standard inference mode. Use `group_by[]=speed` to break out per-mode values.
        /// </param>
        /// <param name="slackChannelIds">
        /// Filter to usage originating from specific Slack channels. Use `group_by[]=slack_channel_id` to break out per-channel values.
        /// </param>
        /// <param name="claudeTagCategories">
        /// Filter to Claude Tag (Claude in Slack) usage in specific spend categories. Usage with no category never matches. `dm` usage is reported under the user's product rather than `claude_tag`, so combining this filter with `products[]=claude_tag` excludes it. Use `group_by[]=claude_tag_category` to break out per-category values.
        /// </param>
        /// <param name="claudeTagUserIds">
        /// Filter to Claude Tag (Claude in Slack) usage attributed to specific Slack users, by Slack user ID (for example `U0123ABCDEF`), not claude.ai user ID. Usage that is not Claude Tag, and Claude Tag usage not attributed to a single user, never matches. Use `group_by[]=claude_tag_user_id` to break out per-user values.
        /// </param>
        /// <param name="workspaceIds">
        /// Filter to usage in specific workspaces, by tagged workspace ID (`wrkspc_...`). Use `group_by[]=workspace_id` to break out per-workspace values. Claude Developer Platform organizations only; matches nothing for a Claude Enterprise organization.
        /// </param>
        /// <param name="serviceTiers">
        /// Filter to specific service tiers. Use `group_by[]=service_tier` to break out per-tier values. Claude Developer Platform organizations only; matches nothing for a Claude Enterprise organization.
        /// </param>
        /// <param name="rbacGroupIds">
        /// Filter to usage attributed to specific RBAC groups. Accepts tagged RBAC group IDs (`rbac_group_...`) or bare group UUIDs. A row matches when the user belonged to any of the listed groups on the (UTC) day the usage occurred; usage with no group attribution never matches.
        /// </param>
        /// <param name="userProfileIds">
        /// Filter to usage attributed to specific user profiles, by tagged user profile ID (`uprof_...`). Use `group_by[]=user_profile_id` to break out per-profile values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="agentIds">
        /// Filter to usage incurred by sessions of specific Claude Managed Agents agents. Use `group_by[]=agent_id` to break out per-agent values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="environmentIds">
        /// Filter to usage incurred by Claude Managed Agents sessions that ran in specific environments. Use `group_by[]=environment_id` to break out per-environment values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="deploymentIds">
        /// Filter to usage incurred by Claude Managed Agents sessions that specific deployments started. Use `group_by[]=deployment_id` to break out per-deployment values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="sessionIds">
        /// Filter to usage incurred by specific Claude Managed Agents sessions, by tagged session ID (`sesn_...`). Use `group_by[]=session_id` to break out per-session values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="actorIds">
        /// Filter to usage attributed to specific identities, by tagged ID: a `user_...`, `svac_...` (service account), or `apikey_...` ID. An `apikey_` entry matches only usage attributed to the key itself, not usage on that key attributed to a user or service account (use `api_key_ids[]` for every request a key authenticated). Federated identities have no tagged ID; select them with `actor_types[]`. Use `group_by[]=actor` to break out per-identity values.
        /// </param>
        /// <param name="actorTypes">
        /// Filter to usage attributed to specific kinds of identity. Use `group_by[]=actor_type` to break out per-kind values.
        /// </param>
        /// <param name="apiKeyIds">
        /// Filter to usage authenticated by specific API keys, by tagged API key ID (`apikey_...`), whichever identity the usage is attributed to. Include an empty entry (`api_key_ids[]=`) to also match usage that no API key authenticated. Use `group_by[]=api_key_id` to break out per-key values; usage without a key has a null `api_key_id`. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="timeBucketWidth">
        /// Time-bucket granularity. When set, rows are returned per time bucket (one per bucket and dimension combination with usage) and each row's `starting_at` and `ending_at` are that bucket's bounds; the time bucket counts toward `limit`. `ending_at` is required when `time_bucket_width` is set, and with `time_bucket_width="1m"` the range may span at most 24 hours. When omitted, each row aggregates the requested range with `starting_at` and `ending_at` each rounded down to the hour.
        /// </param>
        /// <param name="order">
        /// Sort direction of the `order_by` metric, or of the time buckets when `order_by` is `time` and `time_bucket_width` is set. Defaults to `desc`.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="excludeDeletedUsers">
        /// If true, omit rows whose `actor` is a `user_actor` with `deleted: true`. Requires `group_by[]=actor`. Rows for other actor types, and rows whose `actor` is null, are always kept. A page may contain fewer than `limit` rows; use `has_more` and `next_page` to paginate as usual.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Number of rows per page (1-1000, default 20). `cost_type`/`token_type` fan-out rows (cost endpoint only) do not count toward this limit, so `data` can exceed it.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="orderBy">
        /// Row order. A metric ranks rows by that metric in the `order` direction. `time` orders rows by time bucket in the `order` direction (newest first by default) and, within a bucket, by `amount`, highest first. `time` takes effect only with `time_bucket_width`; without it, `time` is the same as `amount`. Defaults to `amount`.<br/>
        /// Default Value: amount
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break cost out by (at most 5, not counting `cost_type` and `token_type`): one row per combination of their values with cost in the range (and per time bucket, when `time_bucket_width` is set), every combination returned across pages rather than a capped top set. `cost_type` and `token_type` do not count toward `limit`: `cost_type` returns one row per cost component (tokens, web search, code execution, and `session_usage`, Claude Managed Agents session time); `token_type` returns one row per token type, each with `cost_type: "tokens"`; combining both returns the per-token-type rows plus the web-search, code-execution and session-usage rows. When omitted, a single row aggregates the whole range.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `analytics-usage-cost-2026-08-24` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsFlatCostResponse>> BetaGetCostV1OrganizationsAnalyticsCostGetAsResponseAsync(
            global::System.DateTime startingAt,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? products = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? speeds = default,
            global::System.Collections.Generic.IList<string>? slackChannelIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories = default,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<string>? rbacGroupIds = default,
            global::System.Collections.Generic.IList<string>? userProfileIds = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? environmentIds = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<string>? sessionIds = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? actorTypes = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::Anthropic.BetaAnalyticsTimeBucketWidth? timeBucketWidth = default,
            global::Anthropic.BetaAnalyticsUsageCostSortOrder? order = default,
            bool? excludeDeletedUsers = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaAnalyticsFlatCostOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostGroupBy>? groupBy = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetCostV1OrganizationsAnalyticsCostGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaAnalyticsFlatCostItem&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="startingAt">
        /// Start of range, inclusive. RFC 3339 tz-aware. Must be within the last 365 days and no earlier than 2026-01-01T00:00:00Z.
        /// </param>
        /// <param name="endingAt">
        /// End of range, exclusive. Required when `time_bucket_width` is set. Without `time_bucket_width`, defaults to the earlier of now and `starting_at` + 31 days. The range may span at most 31 days.
        /// </param>
        /// <param name="products">
        /// Product surfaces to include. Defaults to all products.
        /// </param>
        /// <param name="models">
        /// Models to include. Defaults to all models. Use `group_by[]=model` to break out per-model values.
        /// </param>
        /// <param name="contextWindows">
        /// Filter to specific context-window pricing tiers. Use `group_by[]=context_window` to break out per-tier values.
        /// </param>
        /// <param name="inferenceGeos">
        /// Filter to specific inference regions. `not_available` matches rows where the region is unset. Use `group_by[]=inference_geo` to break out per-region values.
        /// </param>
        /// <param name="speeds">
        /// Filter to fast or standard inference mode. Use `group_by[]=speed` to break out per-mode values.
        /// </param>
        /// <param name="slackChannelIds">
        /// Filter to usage originating from specific Slack channels. Use `group_by[]=slack_channel_id` to break out per-channel values.
        /// </param>
        /// <param name="claudeTagCategories">
        /// Filter to Claude Tag (Claude in Slack) usage in specific spend categories. Usage with no category never matches. `dm` usage is reported under the user's product rather than `claude_tag`, so combining this filter with `products[]=claude_tag` excludes it. Use `group_by[]=claude_tag_category` to break out per-category values.
        /// </param>
        /// <param name="claudeTagUserIds">
        /// Filter to Claude Tag (Claude in Slack) usage attributed to specific Slack users, by Slack user ID (for example `U0123ABCDEF`), not claude.ai user ID. Usage that is not Claude Tag, and Claude Tag usage not attributed to a single user, never matches. Use `group_by[]=claude_tag_user_id` to break out per-user values.
        /// </param>
        /// <param name="workspaceIds">
        /// Filter to usage in specific workspaces, by tagged workspace ID (`wrkspc_...`). Use `group_by[]=workspace_id` to break out per-workspace values. Claude Developer Platform organizations only; matches nothing for a Claude Enterprise organization.
        /// </param>
        /// <param name="serviceTiers">
        /// Filter to specific service tiers. Use `group_by[]=service_tier` to break out per-tier values. Claude Developer Platform organizations only; matches nothing for a Claude Enterprise organization.
        /// </param>
        /// <param name="rbacGroupIds">
        /// Filter to usage attributed to specific RBAC groups. Accepts tagged RBAC group IDs (`rbac_group_...`) or bare group UUIDs. A row matches when the user belonged to any of the listed groups on the (UTC) day the usage occurred; usage with no group attribution never matches.
        /// </param>
        /// <param name="userProfileIds">
        /// Filter to usage attributed to specific user profiles, by tagged user profile ID (`uprof_...`). Use `group_by[]=user_profile_id` to break out per-profile values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="agentIds">
        /// Filter to usage incurred by sessions of specific Claude Managed Agents agents. Use `group_by[]=agent_id` to break out per-agent values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="environmentIds">
        /// Filter to usage incurred by Claude Managed Agents sessions that ran in specific environments. Use `group_by[]=environment_id` to break out per-environment values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="deploymentIds">
        /// Filter to usage incurred by Claude Managed Agents sessions that specific deployments started. Use `group_by[]=deployment_id` to break out per-deployment values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="sessionIds">
        /// Filter to usage incurred by specific Claude Managed Agents sessions, by tagged session ID (`sesn_...`). Use `group_by[]=session_id` to break out per-session values. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="actorIds">
        /// Filter to usage attributed to specific identities, by tagged ID: a `user_...`, `svac_...` (service account), or `apikey_...` ID. An `apikey_` entry matches only usage attributed to the key itself, not usage on that key attributed to a user or service account (use `api_key_ids[]` for every request a key authenticated). Federated identities have no tagged ID; select them with `actor_types[]`. Use `group_by[]=actor` to break out per-identity values.
        /// </param>
        /// <param name="actorTypes">
        /// Filter to usage attributed to specific kinds of identity. Use `group_by[]=actor_type` to break out per-kind values.
        /// </param>
        /// <param name="apiKeyIds">
        /// Filter to usage authenticated by specific API keys, by tagged API key ID (`apikey_...`), whichever identity the usage is attributed to. Include an empty entry (`api_key_ids[]=`) to also match usage that no API key authenticated. Use `group_by[]=api_key_id` to break out per-key values; usage without a key has a null `api_key_id`. Claude Developer Platform organizations only.
        /// </param>
        /// <param name="timeBucketWidth">
        /// Time-bucket granularity. When set, rows are returned per time bucket (one per bucket and dimension combination with usage) and each row's `starting_at` and `ending_at` are that bucket's bounds; the time bucket counts toward `limit`. `ending_at` is required when `time_bucket_width` is set, and with `time_bucket_width="1m"` the range may span at most 24 hours. When omitted, each row aggregates the requested range with `starting_at` and `ending_at` each rounded down to the hour.
        /// </param>
        /// <param name="order">
        /// Sort direction of the `order_by` metric, or of the time buckets when `order_by` is `time` and `time_bucket_width` is set. Defaults to `desc`.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="excludeDeletedUsers">
        /// If true, omit rows whose `actor` is a `user_actor` with `deleted: true`. Requires `group_by[]=actor`. Rows for other actor types, and rows whose `actor` is null, are always kept. A page may contain fewer than `limit` rows; use `has_more` and `next_page` to paginate as usual.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Number of rows per page (1-1000, default 20). `cost_type`/`token_type` fan-out rows (cost endpoint only) do not count toward this limit, so `data` can exceed it.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy">
        /// Row order. A metric ranks rows by that metric in the `order` direction. `time` orders rows by time bucket in the `order` direction (newest first by default) and, within a bucket, by `amount`, highest first. `time` takes effect only with `time_bucket_width`; without it, `time` is the same as `amount`. Defaults to `amount`.<br/>
        /// Default Value: amount
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break cost out by (at most 5, not counting `cost_type` and `token_type`): one row per combination of their values with cost in the range (and per time bucket, when `time_bucket_width` is set), every combination returned across pages rather than a capped top set. `cost_type` and `token_type` do not count toward `limit`: `cost_type` returns one row per cost component (tokens, web search, code execution, and `session_usage`, Claude Managed Agents session time); `token_type` returns one row per token type, each with `cost_type: "tokens"`; combining both returns the per-token-type rows plus the web-search, code-execution and session-usage rows. When omitted, a single row aggregates the whole range.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `analytics-usage-cost-2026-08-24` in this header.
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaAnalyticsFlatCostItem> BetaGetCostV1OrganizationsAnalyticsCostGetAutoPagingAsync(
            global::System.DateTime startingAt,             global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? products = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? speeds = default,
            global::System.Collections.Generic.IList<string>? slackChannelIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories = default,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<string>? rbacGroupIds = default,
            global::System.Collections.Generic.IList<string>? userProfileIds = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? environmentIds = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<string>? sessionIds = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? actorTypes = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::Anthropic.BetaAnalyticsTimeBucketWidth? timeBucketWidth = default,
            global::Anthropic.BetaAnalyticsUsageCostSortOrder? order = default,
            bool? excludeDeletedUsers = default,
            int? limit = default,
            global::Anthropic.BetaAnalyticsFlatCostOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostGroupBy>? groupBy = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}