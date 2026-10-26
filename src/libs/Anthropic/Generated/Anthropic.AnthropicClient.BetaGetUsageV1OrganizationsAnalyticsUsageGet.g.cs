
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaGetUsageV1OrganizationsAnalyticsUsageGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime startingAt,
            global::System.DateTime? endingAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? products,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? speeds,
            global::System.Collections.Generic.IList<string>? slackChannelIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds,
            global::System.Collections.Generic.IList<string>? workspaceIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers,
            global::System.Collections.Generic.IList<string>? rbacGroupIds,
            global::System.Collections.Generic.IList<string>? userProfileIds,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? environmentIds,
            global::System.Collections.Generic.IList<string>? deploymentIds,
            global::System.Collections.Generic.IList<string>? sessionIds,
            global::System.Collections.Generic.IList<string>? actorIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? actorTypes,
            global::System.Collections.Generic.IList<string>? apiKeyIds,
            ref global::Anthropic.BetaAnalyticsTimeBucketWidth? timeBucketWidth,
            ref global::Anthropic.BetaAnalyticsUsageCostSortOrder? order,
            ref bool? excludeDeletedUsers,
            ref int? limit,
            ref string? page,
            ref global::Anthropic.BetaAnalyticsFlatUsageOrderBy? orderBy,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? groupBy,
            ref string? anthropicVersion,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta);
        partial void PrepareBetaGetUsageV1OrganizationsAnalyticsUsageGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime startingAt,
            global::System.DateTime? endingAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? products,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? speeds,
            global::System.Collections.Generic.IList<string>? slackChannelIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds,
            global::System.Collections.Generic.IList<string>? workspaceIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers,
            global::System.Collections.Generic.IList<string>? rbacGroupIds,
            global::System.Collections.Generic.IList<string>? userProfileIds,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? environmentIds,
            global::System.Collections.Generic.IList<string>? deploymentIds,
            global::System.Collections.Generic.IList<string>? sessionIds,
            global::System.Collections.Generic.IList<string>? actorIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? actorTypes,
            global::System.Collections.Generic.IList<string>? apiKeyIds,
            global::Anthropic.BetaAnalyticsTimeBucketWidth? timeBucketWidth,
            global::Anthropic.BetaAnalyticsUsageCostSortOrder? order,
            bool? excludeDeletedUsers,
            int? limit,
            string? page,
            global::Anthropic.BetaAnalyticsFlatUsageOrderBy? orderBy,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? groupBy,
            string? anthropicVersion,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta);
        partial void ProcessBetaGetUsageV1OrganizationsAnalyticsUsageGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaGetUsageV1OrganizationsAnalyticsUsageGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Token Usage By Dimension<br/>
        /// Get token usage across a date range, broken out by dimension.<br/>
        /// Returns one row per combination of the requested `group_by[]`<br/>
        /// dimensions (and time bucket, when `time_bucket_width` is set) that has<br/>
        /// usage in the range, ranked by the `order_by` metric or ordered by time<br/>
        /// bucket; every combination is returned across pages. With no `group_by[]`<br/>
        /// and no `time_bucket_width`, a single row aggregates the whole range.<br/>
        /// Includes all usage, whether or not it is attributable to a seat user.<br/>
        /// Requires an API key with the `read:analytics` scope, or an Admin API key.
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
        /// Row order. A metric ranks rows by that metric in the `order` direction. `time` orders rows by time bucket in the `order` direction (newest first by default) and, within a bucket, by `total_tokens`, highest first. `time` takes effect only with `time_bucket_width`; without it, `time` is the same as `total_tokens`. Defaults to `total_tokens`.<br/>
        /// Default Value: total_tokens
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break usage out by (at most 5): one row per combination of their values with usage in the range (and per time bucket, when `time_bucket_width` is set), every combination returned across pages rather than a capped top set. When omitted, a single row aggregates the whole range.
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
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsFlatUsageResponse> BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync(
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
            global::Anthropic.BetaAnalyticsFlatUsageOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? groupBy = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaGetUsageV1OrganizationsAnalyticsUsageGetAsResponseAsync(
                startingAt: startingAt,
                endingAt: endingAt,
                products: products,
                models: models,
                contextWindows: contextWindows,
                inferenceGeos: inferenceGeos,
                speeds: speeds,
                slackChannelIds: slackChannelIds,
                claudeTagCategories: claudeTagCategories,
                claudeTagUserIds: claudeTagUserIds,
                workspaceIds: workspaceIds,
                serviceTiers: serviceTiers,
                rbacGroupIds: rbacGroupIds,
                userProfileIds: userProfileIds,
                agentIds: agentIds,
                environmentIds: environmentIds,
                deploymentIds: deploymentIds,
                sessionIds: sessionIds,
                actorIds: actorIds,
                actorTypes: actorTypes,
                apiKeyIds: apiKeyIds,
                timeBucketWidth: timeBucketWidth,
                order: order,
                excludeDeletedUsers: excludeDeletedUsers,
                limit: limit,
                page: page,
                orderBy: orderBy,
                groupBy: groupBy,
                anthropicVersion: anthropicVersion,
                anthropicBeta: anthropicBeta,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Token Usage By Dimension<br/>
        /// Get token usage across a date range, broken out by dimension.<br/>
        /// Returns one row per combination of the requested `group_by[]`<br/>
        /// dimensions (and time bucket, when `time_bucket_width` is set) that has<br/>
        /// usage in the range, ranked by the `order_by` metric or ordered by time<br/>
        /// bucket; every combination is returned across pages. With no `group_by[]`<br/>
        /// and no `time_bucket_width`, a single row aggregates the whole range.<br/>
        /// Includes all usage, whether or not it is attributable to a seat user.<br/>
        /// Requires an API key with the `read:analytics` scope, or an Admin API key.
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
        /// Row order. A metric ranks rows by that metric in the `order` direction. `time` orders rows by time bucket in the `order` direction (newest first by default) and, within a bucket, by `total_tokens`, highest first. `time` takes effect only with `time_bucket_width`; without it, `time` is the same as `total_tokens`. Defaults to `total_tokens`.<br/>
        /// Default Value: total_tokens
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break usage out by (at most 5): one row per combination of their values with usage in the range (and per time bucket, when `time_bucket_width` is set), every combination returned across pages rather than a capped top set. When omitted, a single row aggregates the whole range.
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
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsFlatUsageResponse>> BetaGetUsageV1OrganizationsAnalyticsUsageGetAsResponseAsync(
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
            global::Anthropic.BetaAnalyticsFlatUsageOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? groupBy = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var JsonSerializerContext = JsonSerializerContextProvider?.Value ??
                global::Anthropic.SourceGenerationContextOperation_F81BE99CA3144603.Default;
            PrepareArguments(
                client: HttpClient);
            PrepareBetaGetUsageV1OrganizationsAnalyticsUsageGetArguments(
                httpClient: HttpClient,
                startingAt: ref startingAt,
                endingAt: endingAt,
                products: products,
                models: models,
                contextWindows: contextWindows,
                inferenceGeos: inferenceGeos,
                speeds: speeds,
                slackChannelIds: slackChannelIds,
                claudeTagCategories: claudeTagCategories,
                claudeTagUserIds: claudeTagUserIds,
                workspaceIds: workspaceIds,
                serviceTiers: serviceTiers,
                rbacGroupIds: rbacGroupIds,
                userProfileIds: userProfileIds,
                agentIds: agentIds,
                environmentIds: environmentIds,
                deploymentIds: deploymentIds,
                sessionIds: sessionIds,
                actorIds: actorIds,
                actorTypes: actorTypes,
                apiKeyIds: apiKeyIds,
                timeBucketWidth: ref timeBucketWidth,
                order: ref order,
                excludeDeletedUsers: ref excludeDeletedUsers,
                limit: ref limit,
                page: ref page,
                orderBy: ref orderBy,
                groupBy: groupBy,
                anthropicVersion: ref anthropicVersion,
                anthropicBeta: anthropicBeta);

            using var __timeoutCancellationTokenSource = global::Anthropic.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Anthropic.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Anthropic.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Anthropic.PathBuilder(
                                path: "/v1/organizations/analytics/usage?beta=true",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("starting_at", startingAt.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("ending_at", endingAt?.ToString())
                                .AddOptionalParameter("products[]", products, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("models[]", models, delimiter: ",", explode: true)
                                .AddOptionalParameter("context_windows[]", contextWindows, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("inference_geos[]", inferenceGeos, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("speeds[]", speeds, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("slack_channel_ids[]", slackChannelIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("claude_tag_categories[]", claudeTagCategories, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("claude_tag_user_ids[]", claudeTagUserIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("workspace_ids[]", workspaceIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("service_tiers[]", serviceTiers, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("rbac_group_ids[]", rbacGroupIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("user_profile_ids[]", userProfileIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("agent_ids[]", agentIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("environment_ids[]", environmentIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("deployment_ids[]", deploymentIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("session_ids[]", sessionIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("actor_ids[]", actorIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("actor_types[]", actorTypes, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("api_key_ids[]", apiKeyIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("time_bucket_width", timeBucketWidth?.ToValueString())
                                .AddOptionalParameter("order", order?.ToValueString())
                                .AddOptionalParameter("exclude_deleted_users", excludeDeletedUsers?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("page", page)
                                .AddOptionalParameter("order_by", orderBy?.ToValueString())
                                .AddOptionalParameter("group_by[]", groupBy, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Anthropic.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (anthropicVersion != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-version", anthropicVersion.ToString());
            }
            if (anthropicBeta != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-beta", anthropicBeta.ToString());
            }

                global::Anthropic.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareBetaGetUsageV1OrganizationsAnalyticsUsageGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    startingAt: startingAt,
                    endingAt: endingAt,
                    products: products,
                    models: models,
                    contextWindows: contextWindows,
                    inferenceGeos: inferenceGeos,
                    speeds: speeds,
                    slackChannelIds: slackChannelIds,
                    claudeTagCategories: claudeTagCategories,
                    claudeTagUserIds: claudeTagUserIds,
                    workspaceIds: workspaceIds,
                    serviceTiers: serviceTiers,
                    rbacGroupIds: rbacGroupIds,
                    userProfileIds: userProfileIds,
                    agentIds: agentIds,
                    environmentIds: environmentIds,
                    deploymentIds: deploymentIds,
                    sessionIds: sessionIds,
                    actorIds: actorIds,
                    actorTypes: actorTypes,
                    apiKeyIds: apiKeyIds,
                    timeBucketWidth: timeBucketWidth,
                    order: order,
                    excludeDeletedUsers: excludeDeletedUsers,
                    limit: limit,
                    page: page,
                    orderBy: orderBy,
                    groupBy: groupBy,
                    anthropicVersion: anthropicVersion,
                    anthropicBeta: anthropicBeta);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetUsageV1OrganizationsAnalyticsUsageGet",
                                methodName: "BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/usage?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Anthropic.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetUsageV1OrganizationsAnalyticsUsageGet",
                                methodName: "BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/usage?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Anthropic.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Anthropic.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Anthropic.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetUsageV1OrganizationsAnalyticsUsageGet",
                                methodName: "BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/usage?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Anthropic.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessBetaGetUsageV1OrganizationsAnalyticsUsageGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetUsageV1OrganizationsAnalyticsUsageGet",
                                methodName: "BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/usage?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetUsageV1OrganizationsAnalyticsUsageGet",
                                methodName: "BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/usage?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid argument - The client specified an invalid argument
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Anthropic.BetaErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Anthropic.BetaErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Anthropic.BetaErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthenticated - The request does not have valid authentication credentials
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Anthropic.BetaErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Anthropic.BetaErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Anthropic.BetaErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Permission denied - The caller does not have permission to execute the specified operation
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Anthropic.BetaErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Anthropic.BetaErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Anthropic.BetaErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not found - Some requested entity was not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Anthropic.BetaErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Anthropic.BetaErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Anthropic.BetaErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Deadline exceeded - The deadline expired before the operation could complete
                            if ((int)__response.StatusCode == 408)
                            {
                                string? __content_408 = null;
                                global::System.Exception? __exception_408 = null;
                                global::Anthropic.BetaErrorResponse? __value_408 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_408 = global::Anthropic.BetaErrorResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_408 = global::Anthropic.BetaErrorResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_408 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_408 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_408,
                                    responseBody: __content_408,
                                    responseObject: __value_408,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Aborted - The operation was aborted due to concurrency issue
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::Anthropic.BetaErrorResponse? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = global::Anthropic.BetaErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = global::Anthropic.BetaErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    responseBody: __content_409,
                                    responseObject: __value_409,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Failed precondition - Operation was rejected because the system is not in required state
                            if ((int)__response.StatusCode == 412)
                            {
                                string? __content_412 = null;
                                global::System.Exception? __exception_412 = null;
                                global::Anthropic.BetaErrorResponse? __value_412 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_412 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_412 = global::Anthropic.BetaErrorResponse.FromJson(__content_412, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_412 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_412 = global::Anthropic.BetaErrorResponse.FromJson(__content_412, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_412 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_412 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_412,
                                    responseBody: __content_412,
                                    responseObject: __value_412,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Out of range - Operation was attempted past the valid range
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::Anthropic.BetaErrorResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::Anthropic.BetaErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::Anthropic.BetaErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Resource exhausted - Some resource has been exhausted (rate limiting)
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Anthropic.BetaErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Anthropic.BetaErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Anthropic.BetaErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Request header fields too large - Request metadata was too large
                            if ((int)__response.StatusCode == 431)
                            {
                                string? __content_431 = null;
                                global::System.Exception? __exception_431 = null;
                                global::Anthropic.BetaErrorResponse? __value_431 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_431 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_431 = global::Anthropic.BetaErrorResponse.FromJson(__content_431, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_431 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_431 = global::Anthropic.BetaErrorResponse.FromJson(__content_431, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_431 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_431 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_431,
                                    responseBody: __content_431,
                                    responseObject: __value_431,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Cancelled - The operation was cancelled by the client
                            if ((int)__response.StatusCode == 499)
                            {
                                string? __content_499 = null;
                                global::System.Exception? __exception_499 = null;
                                global::Anthropic.BetaErrorResponse? __value_499 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_499 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_499 = global::Anthropic.BetaErrorResponse.FromJson(__content_499, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_499 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_499 = global::Anthropic.BetaErrorResponse.FromJson(__content_499, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_499 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_499 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_499,
                                    responseBody: __content_499,
                                    responseObject: __value_499,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal - Internal server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Anthropic.BetaErrorResponse? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Anthropic.BetaErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Anthropic.BetaErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unimplemented - The operation is not implemented or supported
                            if ((int)__response.StatusCode == 501)
                            {
                                string? __content_501 = null;
                                global::System.Exception? __exception_501 = null;
                                global::Anthropic.BetaErrorResponse? __value_501 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_501 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_501 = global::Anthropic.BetaErrorResponse.FromJson(__content_501, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_501 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_501 = global::Anthropic.BetaErrorResponse.FromJson(__content_501, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_501 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_501 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_501,
                                    responseBody: __content_501,
                                    responseObject: __value_501,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unavailable - The service is currently unavailable
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::Anthropic.BetaErrorResponse? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::Anthropic.BetaErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::Anthropic.BetaErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Deadline exceeded - Upstream service did not respond in time
                            if ((int)__response.StatusCode == 504)
                            {
                                string? __content_504 = null;
                                global::System.Exception? __exception_504 = null;
                                global::Anthropic.BetaErrorResponse? __value_504 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_504 = global::Anthropic.BetaErrorResponse.FromJson(__content_504, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_504 = global::Anthropic.BetaErrorResponse.FromJson(__content_504, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_504 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_504,
                                    responseBody: __content_504,
                                    responseObject: __value_504,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Overloaded - The service is temporarily overloaded
                            if ((int)__response.StatusCode == 529)
                            {
                                string? __content_529 = null;
                                global::System.Exception? __exception_529 = null;
                                global::Anthropic.BetaErrorResponse? __value_529 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_529 = global::Anthropic.BetaErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_529 = global::Anthropic.BetaErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_529 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_529 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_529,
                                    responseBody: __content_529,
                                    responseObject: __value_529,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessBetaGetUsageV1OrganizationsAnalyticsUsageGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaAnalyticsFlatUsageResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsFlatUsageResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Anthropic.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Anthropic.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Anthropic.BetaAnalyticsFlatUsageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsFlatUsageResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Anthropic.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Anthropic.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }

        /// <summary>
        /// Wraps BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaAnalyticsFlatUsageItem&gt; that auto-pages over the response.
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
        /// Row order. A metric ranks rows by that metric in the `order` direction. `time` orders rows by time bucket in the `order` direction (newest first by default) and, within a bucket, by `total_tokens`, highest first. `time` takes effect only with `time_bucket_width`; without it, `time` is the same as `total_tokens`. Defaults to `total_tokens`.<br/>
        /// Default Value: total_tokens
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break usage out by (at most 5): one row per combination of their values with usage in the range (and per time bucket, when `time_bucket_width` is set), every combination returned across pages rather than a capped top set. When omitted, a single row aggregates the whole range.
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
        public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaAnalyticsFlatUsageItem> BetaGetUsageV1OrganizationsAnalyticsUsageGetAutoPagingAsync(
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
            global::Anthropic.BetaAnalyticsFlatUsageOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? groupBy = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Anthropic.AutoSDKPager.CursorAsync<global::Anthropic.BetaAnalyticsFlatUsageResponse, global::Anthropic.BetaAnalyticsFlatUsageItem>(
                fetchPage: (__cursor, __ct) => BetaGetUsageV1OrganizationsAnalyticsUsageGetAsync(
                    startingAt: startingAt,
                    endingAt: endingAt,
                    products: products,
                    models: models,
                    contextWindows: contextWindows,
                    inferenceGeos: inferenceGeos,
                    speeds: speeds,
                    slackChannelIds: slackChannelIds,
                    claudeTagCategories: claudeTagCategories,
                    claudeTagUserIds: claudeTagUserIds,
                    workspaceIds: workspaceIds,
                    serviceTiers: serviceTiers,
                    rbacGroupIds: rbacGroupIds,
                    userProfileIds: userProfileIds,
                    agentIds: agentIds,
                    environmentIds: environmentIds,
                    deploymentIds: deploymentIds,
                    sessionIds: sessionIds,
                    actorIds: actorIds,
                    actorTypes: actorTypes,
                    apiKeyIds: apiKeyIds,
                    timeBucketWidth: timeBucketWidth,
                    order: order,
                    excludeDeletedUsers: excludeDeletedUsers,
                    limit: limit,
                    page: __cursor,
                    orderBy: orderBy,
                    groupBy: groupBy,
                    anthropicVersion: anthropicVersion,
                    anthropicBeta: anthropicBeta,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Anthropic.BetaAnalyticsFlatUsageItem>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPage,
                initialCursor: page,
                cancellationToken: cancellationToken);
        }

    }
}