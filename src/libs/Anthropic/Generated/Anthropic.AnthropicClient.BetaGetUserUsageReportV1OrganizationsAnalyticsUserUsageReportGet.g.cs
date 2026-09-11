
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime startingAt,
            global::System.DateTime? endingAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? products,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? speeds,
            global::System.Collections.Generic.IList<string>? slackChannelIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds,
            global::System.Collections.Generic.IList<string>? rbacGroupIds,
            global::System.Collections.Generic.IList<string>? userIds,
            ref global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? bucketWidth,
            ref global::Anthropic.BetaAnalyticsSortOrder? order,
            ref bool? excludeDeletedUsers,
            ref int? limit,
            ref string? page,
            ref global::Anthropic.BetaAnalyticsUsageUsersOrderBy? orderBy,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? groupBy,
            ref string? xApiKey,
            ref string? anthropicVersion);
        partial void PrepareBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime startingAt,
            global::System.DateTime? endingAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? products,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindows,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? speeds,
            global::System.Collections.Generic.IList<string>? slackChannelIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? claudeTagCategories,
            global::System.Collections.Generic.IList<string>? claudeTagUserIds,
            global::System.Collections.Generic.IList<string>? rbacGroupIds,
            global::System.Collections.Generic.IList<string>? userIds,
            global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? bucketWidth,
            global::Anthropic.BetaAnalyticsSortOrder? order,
            bool? excludeDeletedUsers,
            int? limit,
            string? page,
            global::Anthropic.BetaAnalyticsUsageUsersOrderBy? orderBy,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? groupBy,
            string? xApiKey,
            string? anthropicVersion);
        partial void ProcessBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsUsageUsersResponse> BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsResponseAsync(
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
                rbacGroupIds: rbacGroupIds,
                userIds: userIds,
                bucketWidth: bucketWidth,
                order: order,
                excludeDeletedUsers: excludeDeletedUsers,
                limit: limit,
                page: page,
                orderBy: orderBy,
                groupBy: groupBy,
                xApiKey: xApiKey,
                anthropicVersion: anthropicVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsUsageUsersResponse>> BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetArguments(
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
                rbacGroupIds: rbacGroupIds,
                userIds: userIds,
                bucketWidth: ref bucketWidth,
                order: ref order,
                excludeDeletedUsers: ref excludeDeletedUsers,
                limit: ref limit,
                page: ref page,
                orderBy: ref orderBy,
                groupBy: groupBy,
                xApiKey: ref xApiKey,
                anthropicVersion: ref anthropicVersion);

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
                                path: "/v1/organizations/analytics/user_usage_report?beta=true",
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
                                .AddOptionalParameter("rbac_group_ids[]", rbacGroupIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("user_ids[]", userIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("bucket_width", bucketWidth?.ToValueString())
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

            if (xApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());
            }
            if (anthropicVersion != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-version", anthropicVersion.ToString());
            }

                global::Anthropic.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    startingAt: startingAt!,
                    endingAt: endingAt,
                    products: products,
                    models: models,
                    contextWindows: contextWindows,
                    inferenceGeos: inferenceGeos,
                    speeds: speeds,
                    slackChannelIds: slackChannelIds,
                    claudeTagCategories: claudeTagCategories,
                    claudeTagUserIds: claudeTagUserIds,
                    rbacGroupIds: rbacGroupIds,
                    userIds: userIds,
                    bucketWidth: bucketWidth,
                    order: order,
                    excludeDeletedUsers: excludeDeletedUsers,
                    limit: limit,
                    page: page,
                    orderBy: orderBy,
                    groupBy: groupBy,
                    xApiKey: xApiKey,
                    anthropicVersion: anthropicVersion);

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
                                operationId: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGet",
                                methodName: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/user_usage_report?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGet",
                                methodName: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/user_usage_report?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGet",
                                methodName: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/user_usage_report?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                ProcessBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGet",
                                methodName: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/user_usage_report?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGet",
                                methodName: "BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/user_usage_report?beta=true\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                ProcessBetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaAnalyticsUsageUsersResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsUsageUsersResponse>(
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

                                    var __value = await global::Anthropic.BetaAnalyticsUsageUsersResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsUsageUsersResponse>(
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
        public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaAnalyticsUsageUsersItem> BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAutoPagingAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Anthropic.AutoSDKPager.CursorAsync<global::Anthropic.BetaAnalyticsUsageUsersResponse, global::Anthropic.BetaAnalyticsUsageUsersItem>(
                fetchPage: (__cursor, __ct) => BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetAsync(
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
                    rbacGroupIds: rbacGroupIds,
                    userIds: userIds,
                    bucketWidth: bucketWidth,
                    order: order,
                    excludeDeletedUsers: excludeDeletedUsers,
                    limit: limit,
                    page: __cursor,
                    orderBy: orderBy,
                    groupBy: groupBy,
                    xApiKey: xApiKey,
                    anthropicVersion: anthropicVersion,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Anthropic.BetaAnalyticsUsageUsersItem>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPage,
                initialCursor: page,
                cancellationToken: cancellationToken);
        }

    }
}