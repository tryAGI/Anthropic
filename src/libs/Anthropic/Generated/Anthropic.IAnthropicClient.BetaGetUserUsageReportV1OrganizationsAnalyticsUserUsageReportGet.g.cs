#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Per-User Token Usage<br/>
        /// Get per-user token usage across a date range.<br/>
        /// Returns one row per user, ranked by the chosen token metric. Use this to<br/>
        /// see which users consume the most tokens. Only usage attributable to a<br/>
        /// seat user is included; for organization-wide totals including direct<br/>
        /// API-key and automation traffic, use the bucketed<br/>
        /// `/v1/organizations/analytics/usage_report` endpoint. Available to<br/>
        /// organizations on a Claude Enterprise plan. Requires an API key with the<br/>
        /// `read:analytics` scope.
        /// </summary>
        /// <param name="startingAt">
        /// Start of range, inclusive. RFC 3339 tz-aware. Must be within the last 365 days and no earlier than 2026-01-01T00:00:00Z.
        /// </param>
        /// <param name="endingAt">
        /// End of range, exclusive. When omitted, defaults to the earlier of now and `starting_at` + 31 days. The range may span at most 31 days.
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
        /// Filter to Claude Tag (Claude in Slack) usage in specific spend categories. Usage with no category never matches. `dm` usage is reported under the user's product rather than `claude-tag`, so combining this filter with `products[]=claude-tag` excludes it. Use `group_by[]=claude_tag_category` to break out per-category values.
        /// </param>
        /// <param name="claudeTagUserIds">
        /// Filter to Claude Tag (Claude in Slack) usage attributed to specific Slack users, by Slack user ID (for example `U0123ABCDEF`), not claude.ai user ID. Usage that is not Claude Tag, and Claude Tag usage not attributed to a single user, never matches. Use `group_by[]=claude_tag_user_id` to break out per-user values.
        /// </param>
        /// <param name="rbacGroupIds">
        /// Filter to usage attributed to specific RBAC groups. Accepts tagged RBAC group IDs (`rbac_group_...`) or bare group UUIDs. A row matches when the user belonged to any of the listed groups on the (UTC) day the usage occurred; usage with no group attribution never matches.
        /// </param>
        /// <param name="userIds">
        /// Filter to specific users by tagged user ID.
        /// </param>
        /// <param name="bucketWidth">
        /// Time-bucket granularity. When set, each row's `starting_at` and `ending_at` are populated and one actor may span several rows (one per time bucket with usage). The time bucket counts toward `limit`, so one page can return multiple rows for the same actor. `ending_at` is required when `bucket_width` is set, and with `bucket_width="1m"` the range may span at most 24 hours. When omitted, each row aggregates the full `[starting_at, ending_at)` range.
        /// </param>
        /// <param name="order">
        /// Sort direction. Defaults to `desc`.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="excludeDeletedUsers">
        /// If true, omit rows for users who are deleted (`deleted: true`). A page may contain fewer than `limit` rows; use `has_more` and `next_page` to paginate as usual.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Number of rows per page (1-1000, default 20). One row per actor unless `group_by[]` or `bucket_width` splits an actor across rows; `cost_type`/`token_type` fan-out rows (cost endpoint only) are the exception — they do not count toward this limit, so `data` can exceed it.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="orderBy">
        /// Metric to rank actors by. Defaults to `total_tokens`.<br/>
        /// Default Value: total_tokens
        /// </param>
        /// <param name="groupBy">
        /// Break each actor's row out by the given dimensions. Accepts the same values as the bucketed `/usage_report` endpoint. `limit` bounds (actor × time bucket × dimension) rows — with dimensions or `bucket_width` present, one actor may span several rows.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsUsageUsersResponse> BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync(
            global::System.DateTime startingAt,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? products = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? speeds = default,
            global::System.Collections.Generic.IList<string>? slackChannelIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories = default,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds = default,
            global::System.Collections.Generic.IList<string>? rbacGroupIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? bucketWidth = default,
            global::Anthropic.BetaAnalyticsSortOrder? order = default,
            bool? excludeDeletedUsers = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaAnalyticsUsageUsersOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? groupBy = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Per-User Token Usage<br/>
        /// Get per-user token usage across a date range.<br/>
        /// Returns one row per user, ranked by the chosen token metric. Use this to<br/>
        /// see which users consume the most tokens. Only usage attributable to a<br/>
        /// seat user is included; for organization-wide totals including direct<br/>
        /// API-key and automation traffic, use the bucketed<br/>
        /// `/v1/organizations/analytics/usage_report` endpoint. Available to<br/>
        /// organizations on a Claude Enterprise plan. Requires an API key with the<br/>
        /// `read:analytics` scope.
        /// </summary>
        /// <param name="startingAt">
        /// Start of range, inclusive. RFC 3339 tz-aware. Must be within the last 365 days and no earlier than 2026-01-01T00:00:00Z.
        /// </param>
        /// <param name="endingAt">
        /// End of range, exclusive. When omitted, defaults to the earlier of now and `starting_at` + 31 days. The range may span at most 31 days.
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
        /// Filter to Claude Tag (Claude in Slack) usage in specific spend categories. Usage with no category never matches. `dm` usage is reported under the user's product rather than `claude-tag`, so combining this filter with `products[]=claude-tag` excludes it. Use `group_by[]=claude_tag_category` to break out per-category values.
        /// </param>
        /// <param name="claudeTagUserIds">
        /// Filter to Claude Tag (Claude in Slack) usage attributed to specific Slack users, by Slack user ID (for example `U0123ABCDEF`), not claude.ai user ID. Usage that is not Claude Tag, and Claude Tag usage not attributed to a single user, never matches. Use `group_by[]=claude_tag_user_id` to break out per-user values.
        /// </param>
        /// <param name="rbacGroupIds">
        /// Filter to usage attributed to specific RBAC groups. Accepts tagged RBAC group IDs (`rbac_group_...`) or bare group UUIDs. A row matches when the user belonged to any of the listed groups on the (UTC) day the usage occurred; usage with no group attribution never matches.
        /// </param>
        /// <param name="userIds">
        /// Filter to specific users by tagged user ID.
        /// </param>
        /// <param name="bucketWidth">
        /// Time-bucket granularity. When set, each row's `starting_at` and `ending_at` are populated and one actor may span several rows (one per time bucket with usage). The time bucket counts toward `limit`, so one page can return multiple rows for the same actor. `ending_at` is required when `bucket_width` is set, and with `bucket_width="1m"` the range may span at most 24 hours. When omitted, each row aggregates the full `[starting_at, ending_at)` range.
        /// </param>
        /// <param name="order">
        /// Sort direction. Defaults to `desc`.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="excludeDeletedUsers">
        /// If true, omit rows for users who are deleted (`deleted: true`). A page may contain fewer than `limit` rows; use `has_more` and `next_page` to paginate as usual.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Number of rows per page (1-1000, default 20). One row per actor unless `group_by[]` or `bucket_width` splits an actor across rows; `cost_type`/`token_type` fan-out rows (cost endpoint only) are the exception — they do not count toward this limit, so `data` can exceed it.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="orderBy">
        /// Metric to rank actors by. Defaults to `total_tokens`.<br/>
        /// Default Value: total_tokens
        /// </param>
        /// <param name="groupBy">
        /// Break each actor's row out by the given dimensions. Accepts the same values as the bucketed `/usage_report` endpoint. `limit` bounds (actor × time bucket × dimension) rows — with dimensions or `bucket_width` present, one actor may span several rows.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsUsageUsersResponse>> BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsResponseAsync(
            global::System.DateTime startingAt,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? products = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? speeds = default,
            global::System.Collections.Generic.IList<string>? slackChannelIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories = default,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds = default,
            global::System.Collections.Generic.IList<string>? rbacGroupIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? bucketWidth = default,
            global::Anthropic.BetaAnalyticsSortOrder? order = default,
            bool? excludeDeletedUsers = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaAnalyticsUsageUsersOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? groupBy = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaAnalyticsUsageUsersItem&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="startingAt">
        /// Start of range, inclusive. RFC 3339 tz-aware. Must be within the last 365 days and no earlier than 2026-01-01T00:00:00Z.
        /// </param>
        /// <param name="endingAt">
        /// End of range, exclusive. When omitted, defaults to the earlier of now and `starting_at` + 31 days. The range may span at most 31 days.
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
        /// Filter to Claude Tag (Claude in Slack) usage in specific spend categories. Usage with no category never matches. `dm` usage is reported under the user's product rather than `claude-tag`, so combining this filter with `products[]=claude-tag` excludes it. Use `group_by[]=claude_tag_category` to break out per-category values.
        /// </param>
        /// <param name="claudeTagUserIds">
        /// Filter to Claude Tag (Claude in Slack) usage attributed to specific Slack users, by Slack user ID (for example `U0123ABCDEF`), not claude.ai user ID. Usage that is not Claude Tag, and Claude Tag usage not attributed to a single user, never matches. Use `group_by[]=claude_tag_user_id` to break out per-user values.
        /// </param>
        /// <param name="rbacGroupIds">
        /// Filter to usage attributed to specific RBAC groups. Accepts tagged RBAC group IDs (`rbac_group_...`) or bare group UUIDs. A row matches when the user belonged to any of the listed groups on the (UTC) day the usage occurred; usage with no group attribution never matches.
        /// </param>
        /// <param name="userIds">
        /// Filter to specific users by tagged user ID.
        /// </param>
        /// <param name="bucketWidth">
        /// Time-bucket granularity. When set, each row's `starting_at` and `ending_at` are populated and one actor may span several rows (one per time bucket with usage). The time bucket counts toward `limit`, so one page can return multiple rows for the same actor. `ending_at` is required when `bucket_width` is set, and with `bucket_width="1m"` the range may span at most 24 hours. When omitted, each row aggregates the full `[starting_at, ending_at)` range.
        /// </param>
        /// <param name="order">
        /// Sort direction. Defaults to `desc`.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="excludeDeletedUsers">
        /// If true, omit rows for users who are deleted (`deleted: true`). A page may contain fewer than `limit` rows; use `has_more` and `next_page` to paginate as usual.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Number of rows per page (1-1000, default 20). One row per actor unless `group_by[]` or `bucket_width` splits an actor across rows; `cost_type`/`token_type` fan-out rows (cost endpoint only) are the exception — they do not count toward this limit, so `data` can exceed it.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy">
        /// Metric to rank actors by. Defaults to `total_tokens`.<br/>
        /// Default Value: total_tokens
        /// </param>
        /// <param name="groupBy">
        /// Break each actor's row out by the given dimensions. Accepts the same values as the bucketed `/usage_report` endpoint. `limit` bounds (actor × time bucket × dimension) rows — with dimensions or `bucket_width` present, one actor may span several rows.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaAnalyticsUsageUsersItem> BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAutoPagingAsync(
            global::System.DateTime startingAt,             global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? products = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? speeds = default,
            global::System.Collections.Generic.IList<string>? slackChannelIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories = default,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds = default,
            global::System.Collections.Generic.IList<string>? rbacGroupIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? bucketWidth = default,
            global::Anthropic.BetaAnalyticsSortOrder? order = default,
            bool? excludeDeletedUsers = default,
            int? limit = default,
            global::Anthropic.BetaAnalyticsUsageUsersOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? groupBy = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}