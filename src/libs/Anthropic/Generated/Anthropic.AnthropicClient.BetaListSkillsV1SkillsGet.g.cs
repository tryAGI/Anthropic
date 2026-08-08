
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaListSkillsV1SkillsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? page,
            ref int? limit,
            ref string? source,
            ref string? anthropicBeta,
            ref string? anthropicVersion,
            ref string? xApiKey);
        partial void PrepareBetaListSkillsV1SkillsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? page,
            int? limit,
            string? source,
            string? anthropicBeta,
            string? anthropicVersion,
            string? xApiKey);
        partial void ProcessBetaListSkillsV1SkillsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaListSkillsV1SkillsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Skills
        /// </summary>
        /// <param name="page">
        /// Pagination token for fetching a specific page of results.<br/>
        /// Pass the value from a previous response's `next_page` field to get the next page of results.
        /// </param>
        /// <param name="limit">
        /// Number of results to return per page.<br/>
        /// Maximum value is 100. Defaults to 20.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="source">
        /// Filter skills by source.<br/>
        /// If provided, only skills from the specified source will be returned:<br/>
        /// * `"custom"`: only return user-created skills<br/>
        /// * `"anthropic"`: only return Anthropic-created skills
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaListSkillsResponse> BetaListSkillsV1SkillsGetAsync(
            string? page = default,
            int? limit = default,
            string? source = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaListSkillsV1SkillsGetAsResponseAsync(
                page: page,
                limit: limit,
                source: source,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Skills
        /// </summary>
        /// <param name="page">
        /// Pagination token for fetching a specific page of results.<br/>
        /// Pass the value from a previous response's `next_page` field to get the next page of results.
        /// </param>
        /// <param name="limit">
        /// Number of results to return per page.<br/>
        /// Maximum value is 100. Defaults to 20.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="source">
        /// Filter skills by source.<br/>
        /// If provided, only skills from the specified source will be returned:<br/>
        /// * `"custom"`: only return user-created skills<br/>
        /// * `"anthropic"`: only return Anthropic-created skills
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListSkillsResponse>> BetaListSkillsV1SkillsGetAsResponseAsync(
            string? page = default,
            int? limit = default,
            string? source = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBetaListSkillsV1SkillsGetArguments(
                httpClient: HttpClient,
                page: ref page,
                limit: ref limit,
                source: ref source,
                anthropicBeta: ref anthropicBeta,
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
                                path: "/v1/skills?beta=true",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page", page)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("source", source)
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
                PrepareBetaListSkillsV1SkillsGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    page: page,
                    limit: limit,
                    source: source,
                    anthropicBeta: anthropicBeta,
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
                                operationId: "BetaListSkillsV1SkillsGet",
                                methodName: "BetaListSkillsV1SkillsGetAsync",
                                pathTemplate: "\"/v1/skills?beta=true\"",
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
                                operationId: "BetaListSkillsV1SkillsGet",
                                methodName: "BetaListSkillsV1SkillsGetAsync",
                                pathTemplate: "\"/v1/skills?beta=true\"",
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
                                operationId: "BetaListSkillsV1SkillsGet",
                                methodName: "BetaListSkillsV1SkillsGetAsync",
                                pathTemplate: "\"/v1/skills?beta=true\"",
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
                ProcessBetaListSkillsV1SkillsGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaListSkillsV1SkillsGet",
                                methodName: "BetaListSkillsV1SkillsGetAsync",
                                pathTemplate: "\"/v1/skills?beta=true\"",
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
                                operationId: "BetaListSkillsV1SkillsGet",
                                methodName: "BetaListSkillsV1SkillsGetAsync",
                                pathTemplate: "\"/v1/skills?beta=true\"",
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
                                ProcessBetaListSkillsV1SkillsGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaListSkillsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListSkillsResponse>(
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

                                    var __value = await global::Anthropic.BetaListSkillsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListSkillsResponse>(
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
        /// Wraps BetaListSkillsV1SkillsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaapiSchemasSkillsSkill&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Number of results to return per page.<br/>
        /// Maximum value is 100. Defaults to 20.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="source">
        /// Filter skills by source.<br/>
        /// If provided, only skills from the specified source will be returned:<br/>
        /// * `"custom"`: only return user-created skills<br/>
        /// * `"anthropic"`: only return Anthropic-created skills
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param> 
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaapiSchemasSkillsSkill> BetaListSkillsV1SkillsGetAutoPagingAsync(
              int? limit = default,
            string? source = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Anthropic.AutoSDKPager.CursorAsync<global::Anthropic.BetaListSkillsResponse, global::Anthropic.BetaapiSchemasSkillsSkill>(
                fetchPage: (__cursor, __ct) => BetaListSkillsV1SkillsGetAsync(
                    page: __cursor,
                    limit: limit,
                    source: source,
                    anthropicBeta: anthropicBeta,
                    anthropicVersion: anthropicVersion,
                    xApiKey: xApiKey,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Anthropic.BetaapiSchemasSkillsSkill>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPage,
                initialCursor: page,
                cancellationToken: cancellationToken);
        }

    }
}