
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime startingAt,
            ref int? limit,
            ref string? page,
            ref string? xApiKey,
            ref string? anthropicVersion);
        partial void PrepareBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime startingAt,
            int? limit,
            string? page,
            string? xApiKey,
            string? anthropicVersion);
        partial void ProcessBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Claude Code Usage Report<br/>
        /// Retrieve daily aggregated usage metrics for Claude Code users.<br/>
        /// Enables organizations to analyze developer productivity and build custom dashboards.
        /// </summary>
        /// <param name="startingAt">
        /// UTC date in YYYY-MM-DD format. Returns metrics for this single day only.
        /// </param>
        /// <param name="limit">
        /// Number of records per page (default: 20, max: 1000).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor token from previous response's `next_page` field.
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
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaGetClaudeCodeUsageReportResponse> BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsResponseAsync(
                startingAt: startingAt,
                limit: limit,
                page: page,
                xApiKey: xApiKey,
                anthropicVersion: anthropicVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Claude Code Usage Report<br/>
        /// Retrieve daily aggregated usage metrics for Claude Code users.<br/>
        /// Enables organizations to analyze developer productivity and build custom dashboards.
        /// </summary>
        /// <param name="startingAt">
        /// UTC date in YYYY-MM-DD format. Returns metrics for this single day only.
        /// </param>
        /// <param name="limit">
        /// Number of records per page (default: 20, max: 1000).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor token from previous response's `next_page` field.
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
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetClaudeCodeUsageReportResponse>> BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsResponseAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetArguments(
                httpClient: HttpClient,
                startingAt: ref startingAt,
                limit: ref limit,
                page: ref page,
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
                                path: "/v1/organizations/usage_report/claude_code?beta=true",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("starting_at", startingAt.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("page", page)
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
                PrepareBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    startingAt: startingAt!,
                    limit: limit,
                    page: page,
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
                                operationId: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGet",
                                methodName: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/claude_code?beta=true\"",
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
                                operationId: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGet",
                                methodName: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/claude_code?beta=true\"",
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
                                operationId: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGet",
                                methodName: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/claude_code?beta=true\"",
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
                ProcessBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGet",
                                methodName: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/claude_code?beta=true\"",
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
                                operationId: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGet",
                                methodName: "BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync",
                                pathTemplate: "\"/v1/organizations/usage_report/claude_code?beta=true\"",
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
                                ProcessBetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaGetClaudeCodeUsageReportResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetClaudeCodeUsageReportResponse>(
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

                                    var __value = await global::Anthropic.BetaGetClaudeCodeUsageReportResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetClaudeCodeUsageReportResponse>(
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
        /// Wraps BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaClaudeCodeUsageReportItem&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="startingAt">
        /// UTC date in YYYY-MM-DD format. Returns metrics for this single day only.
        /// </param>
        /// <param name="limit">
        /// Number of records per page (default: 20, max: 1000).<br/>
        /// Default Value: 20
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
        public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaClaudeCodeUsageReportItem> BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAutoPagingAsync(
            global::System.DateTime startingAt,             int? limit = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Anthropic.AutoSDKPager.CursorAsync<global::Anthropic.BetaGetClaudeCodeUsageReportResponse, global::Anthropic.BetaClaudeCodeUsageReportItem>(
                fetchPage: (__cursor, __ct) => BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync(
                    startingAt: startingAt,
                    limit: limit,
                    page: __cursor,
                    xApiKey: xApiKey,
                    anthropicVersion: anthropicVersion,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Anthropic.BetaClaudeCodeUsageReportItem>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPage,
                initialCursor: page,
                cancellationToken: cancellationToken);
        }

    }
}