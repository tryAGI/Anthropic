
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.DateTime? date,
            global::System.DateTime? startingDate,
            global::System.DateTime? endingDate,
            int? limit,
            ref string? page,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? groupBy,
            global::System.Collections.Generic.IList<string>? filter,
            ref string? orderBy,
            ref global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? order,
            ref string? anthropicVersion,
            ref string? xApiKey);
        partial void PrepareBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime? date,
            global::System.DateTime? startingDate,
            global::System.DateTime? endingDate,
            int? limit,
            string? page,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? groupBy,
            global::System.Collections.Generic.IList<string>? filter,
            string? orderBy,
            global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? order,
            string? anthropicVersion,
            string? xApiKey);
        partial void ProcessBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Chat Project Usage<br/>
        /// Get per-project activity for a given day, with cursor-based pagination.<br/>
        /// Returns activity metrics for each project in the organization, sorted by<br/>
        /// project ID. Use `group_by[]` to break projects out per member or per RBAC<br/>
        /// group, and `filter[]` to scope results; the parameter descriptions list the<br/>
        /// supported dimensions. Available to organizations on a Claude Enterprise<br/>
        /// plan. Requires an API key with the `read:analytics` scope.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get project activity for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of a date range (inclusive). Enables rollup mode: one row per entity aggregated over the whole range — addable counters are summed across days, and a distinct count is never summed where summing could double-count (a field's range value is recomputed exactly over the window, approximate via HLL with typical error under 2%, null, or — for the creation-event counts, whose per-day values cannot overlap — a per-day sum that is itself exact; each field's own description says which). Use either `date` or `starting_date`, not both. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive); only valid with `starting_date`. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day), so this can be at most today — which is also the default when omitted, resolved once when the first page is served and reused for the rest of the pagination sequence. At most 366 days after `starting_date`.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100).
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `rbac_group_id`, `user_id`. Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `project_id`, `rbac_group_id`, `user_id`. Value forms: `project_id` takes a tagged project id (`claude_proj_...`); `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
        /// </param>
        /// <param name="orderBy">
        /// Sort field. Restricted to the endpoint's sort column plus its rankable metrics (metrics default to descending; a few metrics rank in date-range mode only, per the endpoint's documented orderable set).
        /// </param>
        /// <param name="order">
        /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsProjectsResponse> BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync(
            global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsResponseAsync(
                date: date,
                startingDate: startingDate,
                endingDate: endingDate,
                limit: limit,
                page: page,
                groupBy: groupBy,
                filter: filter,
                orderBy: orderBy,
                order: order,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Chat Project Usage<br/>
        /// Get per-project activity for a given day, with cursor-based pagination.<br/>
        /// Returns activity metrics for each project in the organization, sorted by<br/>
        /// project ID. Use `group_by[]` to break projects out per member or per RBAC<br/>
        /// group, and `filter[]` to scope results; the parameter descriptions list the<br/>
        /// supported dimensions. Available to organizations on a Claude Enterprise<br/>
        /// plan. Requires an API key with the `read:analytics` scope.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get project activity for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of a date range (inclusive). Enables rollup mode: one row per entity aggregated over the whole range — addable counters are summed across days, and a distinct count is never summed where summing could double-count (a field's range value is recomputed exactly over the window, approximate via HLL with typical error under 2%, null, or — for the creation-event counts, whose per-day values cannot overlap — a per-day sum that is itself exact; each field's own description says which). Use either `date` or `starting_date`, not both. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive); only valid with `starting_date`. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day), so this can be at most today — which is also the default when omitted, resolved once when the first page is served and reused for the rest of the pagination sequence. At most 366 days after `starting_date`.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100).
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `rbac_group_id`, `user_id`. Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `project_id`, `rbac_group_id`, `user_id`. Value forms: `project_id` takes a tagged project id (`claude_proj_...`); `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
        /// </param>
        /// <param name="orderBy">
        /// Sort field. Restricted to the endpoint's sort column plus its rankable metrics (metrics default to descending; a few metrics rank in date-range mode only, per the endpoint's documented orderable set).
        /// </param>
        /// <param name="order">
        /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsProjectsResponse>> BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsResponseAsync(
            global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetArguments(
                httpClient: HttpClient,
                date: date,
                startingDate: startingDate,
                endingDate: endingDate,
                limit: limit,
                page: ref page,
                groupBy: groupBy,
                filter: filter,
                orderBy: ref orderBy,
                order: ref order,
                anthropicVersion: ref anthropicVersion,
                xApiKey: ref xApiKey);

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
                                path: "/v1/organizations/analytics/apps/chat/projects?beta=true",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("date", date?.ToString())
                                .AddOptionalParameter("starting_date", startingDate?.ToString())
                                .AddOptionalParameter("ending_date", endingDate?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("page", page)
                                .AddOptionalParameter("group_by[]", groupBy, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("filter[]", filter, delimiter: ",", explode: true)
                                .AddOptionalParameter("order_by", orderBy)
                                .AddOptionalParameter("order", order?.ToValueString())
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
            if (xApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());
            }

                global::Anthropic.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    date: date,
                    startingDate: startingDate,
                    endingDate: endingDate,
                    limit: limit,
                    page: page,
                    groupBy: groupBy,
                    filter: filter,
                    orderBy: orderBy,
                    order: order,
                    anthropicVersion: anthropicVersion,
                    xApiKey: xApiKey);

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
                                operationId: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGet",
                                methodName: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/apps/chat/projects?beta=true\"",
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
                                operationId: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGet",
                                methodName: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/apps/chat/projects?beta=true\"",
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
                                operationId: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGet",
                                methodName: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/apps/chat/projects?beta=true\"",
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
                ProcessBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGet",
                                methodName: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/apps/chat/projects?beta=true\"",
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
                                operationId: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGet",
                                methodName: "BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync",
                                pathTemplate: "\"/v1/organizations/analytics/apps/chat/projects?beta=true\"",
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
                                ProcessBetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaAnalyticsProjectsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsProjectsResponse>(
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

                                    var __value = await global::Anthropic.BetaAnalyticsProjectsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsProjectsResponse>(
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
        /// Wraps BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaAnalyticsProjectActivity&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get project activity for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of a date range (inclusive). Enables rollup mode: one row per entity aggregated over the whole range — addable counters are summed across days, and a distinct count is never summed where summing could double-count (a field's range value is recomputed exactly over the window, approximate via HLL with typical error under 2%, null, or — for the creation-event counts, whose per-day values cannot overlap — a per-day sum that is itself exact; each field's own description says which). Use either `date` or `starting_date`, not both. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive); only valid with `starting_date`. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day), so this can be at most today — which is also the default when omitted, resolved once when the first page is served and reused for the rest of the pagination sequence. At most 366 days after `starting_date`.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100).
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `rbac_group_id`, `user_id`. Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `project_id`, `rbac_group_id`, `user_id`. Value forms: `project_id` takes a tagged project id (`claude_proj_...`); `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
        /// </param>
        /// <param name="orderBy">
        /// Sort field. Restricted to the endpoint's sort column plus its rankable metrics (metrics default to descending; a few metrics rank in date-range mode only, per the endpoint's documented orderable set).
        /// </param>
        /// <param name="order">
        /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaAnalyticsProjectActivity> BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAutoPagingAsync(
              global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Anthropic.AutoSDKPager.CursorAsync<global::Anthropic.BetaAnalyticsProjectsResponse, global::Anthropic.BetaAnalyticsProjectActivity>(
                fetchPage: (__cursor, __ct) => BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetAsync(
                    date: date,
                    startingDate: startingDate,
                    endingDate: endingDate,
                    limit: limit,
                    page: __cursor,
                    groupBy: groupBy,
                    filter: filter,
                    orderBy: orderBy,
                    order: order,
                    anthropicVersion: anthropicVersion,
                    xApiKey: xApiKey,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Anthropic.BetaAnalyticsProjectActivity>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPage,
                initialCursor: page,
                cancellationToken: cancellationToken);
        }

    }
}