
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref string? page,
            ref global::System.DateTime startingAt,
            global::System.DateTime? endingAt,
            global::System.Collections.Generic.IList<string>? apiKeyIds,
            global::System.Collections.Generic.IList<string>? workspaceIds,
            global::System.Collections.Generic.IList<string>? accountIds,
            global::System.Collections.Generic.IList<string>? serviceAccountIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy,
            ref global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth,
            ref string? anthropicBeta,
            ref string? xApiKey,
            ref string? anthropicVersion);
        partial void PrepareBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            string? page,
            global::System.DateTime startingAt,
            global::System.DateTime? endingAt,
            global::System.Collections.Generic.IList<string>? apiKeyIds,
            global::System.Collections.Generic.IList<string>? workspaceIds,
            global::System.Collections.Generic.IList<string>? accountIds,
            global::System.Collections.Generic.IList<string>? serviceAccountIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy,
            global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth,
            string? anthropicBeta,
            string? xApiKey,
            string? anthropicVersion);
        partial void ProcessBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Messages Usage Report
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// The default and max limits depend on `bucket_width`:<br/>
        /// • `"1d"`: Default of 7 days, maximum of 31 days<br/>
        /// • `"1h"`: Default of 24 hours, maximum of 168 hours<br/>
        /// • `"1m"`: Default of 60 minutes, maximum of 1440 minutes
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="apiKeyIds">
        /// Restrict usage returned to the specified API key ID(s).
        /// </param>
        /// <param name="workspaceIds">
        /// Restrict usage returned to the specified workspace ID(s).
        /// </param>
        /// <param name="accountIds">
        /// Restrict usage returned to the specified user account ID(s).
        /// </param>
        /// <param name="serviceAccountIds">
        /// Restrict usage returned to the specified service account ID(s).
        /// </param>
        /// <param name="models">
        /// Restrict usage returned to the specified model(s).
        /// </param>
        /// <param name="serviceTiers">
        /// Restrict usage returned to the specified service tier(s).
        /// </param>
        /// <param name="contextWindow">
        /// Restrict usage returned to the specified context window(s).
        /// </param>
        /// <param name="inferenceGeos">
        /// Restrict usage returned to the specified inference geo(s). Use `not_available` for models that do not support specifying `inference_geo`.
        /// </param>
        /// <param name="speeds">
        /// Restrict usage returned to the specified speed(s) (Claude Code research preview).<br/>
        /// Requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options. Grouping by `speed` requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaGetMessagesUsageReportResponse> BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<string>? accountIds = default,
            global::System.Collections.Generic.IList<string>? serviceAccountIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy = default,
            global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsResponseAsync(
                startingAt: startingAt,
                limit: limit,
                page: page,
                endingAt: endingAt,
                apiKeyIds: apiKeyIds,
                workspaceIds: workspaceIds,
                accountIds: accountIds,
                serviceAccountIds: serviceAccountIds,
                models: models,
                serviceTiers: serviceTiers,
                contextWindow: contextWindow,
                inferenceGeos: inferenceGeos,
                speeds: speeds,
                groupBy: groupBy,
                bucketWidth: bucketWidth,
                anthropicBeta: anthropicBeta,
                xApiKey: xApiKey,
                anthropicVersion: anthropicVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Messages Usage Report
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// The default and max limits depend on `bucket_width`:<br/>
        /// • `"1d"`: Default of 7 days, maximum of 31 days<br/>
        /// • `"1h"`: Default of 24 hours, maximum of 168 hours<br/>
        /// • `"1m"`: Default of 60 minutes, maximum of 1440 minutes
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="apiKeyIds">
        /// Restrict usage returned to the specified API key ID(s).
        /// </param>
        /// <param name="workspaceIds">
        /// Restrict usage returned to the specified workspace ID(s).
        /// </param>
        /// <param name="accountIds">
        /// Restrict usage returned to the specified user account ID(s).
        /// </param>
        /// <param name="serviceAccountIds">
        /// Restrict usage returned to the specified service account ID(s).
        /// </param>
        /// <param name="models">
        /// Restrict usage returned to the specified model(s).
        /// </param>
        /// <param name="serviceTiers">
        /// Restrict usage returned to the specified service tier(s).
        /// </param>
        /// <param name="contextWindow">
        /// Restrict usage returned to the specified context window(s).
        /// </param>
        /// <param name="inferenceGeos">
        /// Restrict usage returned to the specified inference geo(s). Use `not_available` for models that do not support specifying `inference_geo`.
        /// </param>
        /// <param name="speeds">
        /// Restrict usage returned to the specified speed(s) (Claude Code research preview).<br/>
        /// Requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options. Grouping by `speed` requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetMessagesUsageReportResponse>> BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsResponseAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<string>? accountIds = default,
            global::System.Collections.Generic.IList<string>? serviceAccountIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy = default,
            global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetArguments(
                httpClient: HttpClient,
                limit: ref limit,
                page: ref page,
                startingAt: ref startingAt,
                endingAt: endingAt,
                apiKeyIds: apiKeyIds,
                workspaceIds: workspaceIds,
                accountIds: accountIds,
                serviceAccountIds: serviceAccountIds,
                models: models,
                serviceTiers: serviceTiers,
                contextWindow: contextWindow,
                inferenceGeos: inferenceGeos,
                speeds: speeds,
                groupBy: groupBy,
                bucketWidth: ref bucketWidth,
                anthropicBeta: ref anthropicBeta,
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
                                path: "/v1/organizations/usage_report/messages?beta=true",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("page", page)
                                .AddRequiredParameter("starting_at", startingAt.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("ending_at", endingAt?.ToString())
                                .AddOptionalParameter("api_key_ids[]", apiKeyIds?.ToString())
                                .AddOptionalParameter("workspace_ids[]", workspaceIds?.ToString())
                                .AddOptionalParameter("account_ids[]", accountIds?.ToString())
                                .AddOptionalParameter("service_account_ids[]", serviceAccountIds?.ToString())
                                .AddOptionalParameter("models[]", models?.ToString())
                                .AddOptionalParameter("service_tiers[]", serviceTiers?.ToString())
                                .AddOptionalParameter("context_window[]", contextWindow?.ToString())
                                .AddOptionalParameter("inference_geos[]", inferenceGeos?.ToString())
                                .AddOptionalParameter("speeds[]", speeds?.ToString())
                                .AddOptionalParameter("group_by[]", groupBy?.ToString())
                                .AddOptionalParameter("bucket_width", bucketWidth?.ToValueString())
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

            if (anthropicBeta != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-beta", anthropicBeta.ToString());
            }
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
                PrepareBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    limit: limit,
                    page: page,
                    startingAt: startingAt!,
                    endingAt: endingAt,
                    apiKeyIds: apiKeyIds,
                    workspaceIds: workspaceIds,
                    accountIds: accountIds,
                    serviceAccountIds: serviceAccountIds,
                    models: models,
                    serviceTiers: serviceTiers,
                    contextWindow: contextWindow,
                    inferenceGeos: inferenceGeos,
                    speeds: speeds,
                    groupBy: groupBy,
                    bucketWidth: bucketWidth,
                    anthropicBeta: anthropicBeta,
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
                                operationId: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGet",
                                methodName: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/messages?beta=true\"",
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
                                operationId: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGet",
                                methodName: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/messages?beta=true\"",
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
                                operationId: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGet",
                                methodName: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/messages?beta=true\"",
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
                ProcessBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGet",
                                methodName: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/messages?beta=true\"",
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
                                operationId: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGet",
                                methodName: "BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/messages?beta=true\"",
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
                            // Error response.  See our [errors documentation](https://platform.claude.com/docs/en/api/errors) for more details.
                            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
                            {
                                string? __content_4XX = null;
                                global::System.Exception? __exception_4XX = null;
                                global::Anthropic.BetaErrorResponse? __value_4XX = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_4XX = global::Anthropic.BetaErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_4XX = global::Anthropic.BetaErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_4XX = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_4XX,
                                    responseBody: __content_4XX,
                                    responseObject: __value_4XX,
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
                                ProcessBetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaGetMessagesUsageReportResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetMessagesUsageReportResponse>(
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

                                    var __value = await global::Anthropic.BetaGetMessagesUsageReportResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetMessagesUsageReportResponse>(
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
        /// Wraps BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaMessagesUsageReportTimeBucket&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// The default and max limits depend on `bucket_width`:<br/>
        /// • `"1d"`: Default of 7 days, maximum of 31 days<br/>
        /// • `"1h"`: Default of 24 hours, maximum of 168 hours<br/>
        /// • `"1m"`: Default of 60 minutes, maximum of 1440 minutes
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="apiKeyIds">
        /// Restrict usage returned to the specified API key ID(s).
        /// </param>
        /// <param name="workspaceIds">
        /// Restrict usage returned to the specified workspace ID(s).
        /// </param>
        /// <param name="accountIds">
        /// Restrict usage returned to the specified user account ID(s).
        /// </param>
        /// <param name="serviceAccountIds">
        /// Restrict usage returned to the specified service account ID(s).
        /// </param>
        /// <param name="models">
        /// Restrict usage returned to the specified model(s).
        /// </param>
        /// <param name="serviceTiers">
        /// Restrict usage returned to the specified service tier(s).
        /// </param>
        /// <param name="contextWindow">
        /// Restrict usage returned to the specified context window(s).
        /// </param>
        /// <param name="inferenceGeos">
        /// Restrict usage returned to the specified inference geo(s). Use `not_available` for models that do not support specifying `inference_geo`.
        /// </param>
        /// <param name="speeds">
        /// Restrict usage returned to the specified speed(s) (Claude Code research preview).<br/>
        /// Requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options. Grouping by `speed` requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaMessagesUsageReportTimeBucket> BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAutoPagingAsync(
            global::System.DateTime startingAt,             int? limit = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<string>? accountIds = default,
            global::System.Collections.Generic.IList<string>? serviceAccountIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy = default,
            global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Anthropic.AutoSDKPager.CursorAsync<global::Anthropic.BetaGetMessagesUsageReportResponse, global::Anthropic.BetaMessagesUsageReportTimeBucket>(
                fetchPage: (__cursor, __ct) => BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync(
                    limit: limit,
                    page: __cursor,
                    startingAt: startingAt,
                    endingAt: endingAt,
                    apiKeyIds: apiKeyIds,
                    workspaceIds: workspaceIds,
                    accountIds: accountIds,
                    serviceAccountIds: serviceAccountIds,
                    models: models,
                    serviceTiers: serviceTiers,
                    contextWindow: contextWindow,
                    inferenceGeos: inferenceGeos,
                    speeds: speeds,
                    groupBy: groupBy,
                    bucketWidth: bucketWidth,
                    anthropicBeta: anthropicBeta,
                    xApiKey: xApiKey,
                    anthropicVersion: anthropicVersion,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Anthropic.BetaMessagesUsageReportTimeBucket>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPage,
                initialCursor: page,
                cancellationToken: cancellationToken);
        }

    }
}