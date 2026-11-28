
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaListReviewCasesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? anthropicVersion,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta,
            ref global::Anthropic.BetaComplianceReviewCaseStatusFilter? status,
            ref global::System.DateTime? createdAtGte,
            ref global::System.DateTime? createdAtGt,
            ref global::System.DateTime? createdAtLte,
            ref global::System.DateTime? createdAtLt,
            ref global::System.DateTime? updatedAtGte,
            ref global::System.DateTime? updatedAtGt,
            ref global::System.DateTime? updatedAtLte,
            ref global::System.DateTime? updatedAtLt,
            ref string? userProfileId,
            ref int? limit,
            ref string? page,
            ref global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy,
            ref global::Anthropic.BetaComplianceReviewOrder? order);
        partial void PrepareBetaListReviewCasesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? anthropicVersion,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta,
            global::Anthropic.BetaComplianceReviewCaseStatusFilter? status,
            global::System.DateTime? createdAtGte,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLte,
            global::System.DateTime? createdAtLt,
            global::System.DateTime? updatedAtGte,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLte,
            global::System.DateTime? updatedAtLt,
            string? userProfileId,
            int? limit,
            string? page,
            global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy,
            global::Anthropic.BetaComplianceReviewOrder? order);
        partial void ProcessBetaListReviewCasesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaListReviewCasesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Review Cases<br/>
        /// List the review cases of every organization that the API key can reach, newest first by default. Both open and closed cases are returned unless `status` is set.<br/>
        /// To sync, store the largest `updated_at` you have read, and send it as the at-or-after filter on `updated_at`, sorted by `updated_at` ascending. That finds new cases, newly closed cases, and cases with a new notice. Read every page, match results by `id`, and store the new largest value after the last page.<br/>
        /// A request with the `anthropic-user-profile-id` header and no `user_profile_id` parameter returns a 400 error.<br/>
        /// An Admin API key with the `read:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="status">
        /// A review case status to filter by: `open` or `closed`.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="orderBy">
        /// The field that a list of review cases is sorted by: `created_at` or `updated_at`.
        /// </param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaListReviewCasesResponse> BetaListReviewCasesAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaComplianceReviewCaseStatusFilter? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            string? userProfileId = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaListReviewCasesAsResponseAsync(
                anthropicVersion: anthropicVersion,
                anthropicBeta: anthropicBeta,
                status: status,
                createdAtGte: createdAtGte,
                createdAtGt: createdAtGt,
                createdAtLte: createdAtLte,
                createdAtLt: createdAtLt,
                updatedAtGte: updatedAtGte,
                updatedAtGt: updatedAtGt,
                updatedAtLte: updatedAtLte,
                updatedAtLt: updatedAtLt,
                userProfileId: userProfileId,
                limit: limit,
                page: page,
                orderBy: orderBy,
                order: order,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Review Cases<br/>
        /// List the review cases of every organization that the API key can reach, newest first by default. Both open and closed cases are returned unless `status` is set.<br/>
        /// To sync, store the largest `updated_at` you have read, and send it as the at-or-after filter on `updated_at`, sorted by `updated_at` ascending. That finds new cases, newly closed cases, and cases with a new notice. Read every page, match results by `id`, and store the new largest value after the last page.<br/>
        /// A request with the `anthropic-user-profile-id` header and no `user_profile_id` parameter returns a 400 error.<br/>
        /// An Admin API key with the `read:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="status">
        /// A review case status to filter by: `open` or `closed`.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="orderBy">
        /// The field that a list of review cases is sorted by: `created_at` or `updated_at`.
        /// </param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListReviewCasesResponse>> BetaListReviewCasesAsResponseAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaComplianceReviewCaseStatusFilter? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            string? userProfileId = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var JsonSerializerContext = JsonSerializerContextProvider?.Value ??
                global::Anthropic.SourceGenerationContextOperation_0F2CB7BC46E09A1F.Default;
            PrepareArguments(
                client: HttpClient);
            PrepareBetaListReviewCasesArguments(
                httpClient: HttpClient,
                anthropicVersion: ref anthropicVersion,
                anthropicBeta: anthropicBeta,
                status: ref status,
                createdAtGte: ref createdAtGte,
                createdAtGt: ref createdAtGt,
                createdAtLte: ref createdAtLte,
                createdAtLt: ref createdAtLt,
                updatedAtGte: ref updatedAtGte,
                updatedAtGt: ref updatedAtGt,
                updatedAtLte: ref updatedAtLte,
                updatedAtLt: ref updatedAtLt,
                userProfileId: ref userProfileId,
                limit: ref limit,
                page: ref page,
                orderBy: ref orderBy,
                order: ref order);

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
                                path: "/v1/compliance/review/cases",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("status", status?.ToValueString())
                                .AddOptionalParameter("created_at[gte]", createdAtGte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("created_at[gt]", createdAtGt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("created_at[lte]", createdAtLte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("created_at[lt]", createdAtLt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updated_at[gte]", updatedAtGte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updated_at[gt]", updatedAtGt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updated_at[lte]", updatedAtLte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updated_at[lt]", updatedAtLt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("user_profile_id", userProfileId)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("page", page)
                                .AddOptionalParameter("order_by", orderBy?.ToValueString())
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
            if (anthropicBeta != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-beta", string.Join(",", global::System.Linq.Enumerable.Select(anthropicBeta, static __headerItem => __headerItem.ToString() ?? string.Empty)));
            }

                global::Anthropic.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareBetaListReviewCasesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    anthropicVersion: anthropicVersion,
                    anthropicBeta: anthropicBeta,
                    status: status,
                    createdAtGte: createdAtGte,
                    createdAtGt: createdAtGt,
                    createdAtLte: createdAtLte,
                    createdAtLt: createdAtLt,
                    updatedAtGte: updatedAtGte,
                    updatedAtGt: updatedAtGt,
                    updatedAtLte: updatedAtLte,
                    updatedAtLt: updatedAtLt,
                    userProfileId: userProfileId,
                    limit: limit,
                    page: page,
                    orderBy: orderBy,
                    order: order);

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
                                operationId: "BetaListReviewCases",
                                methodName: "BetaListReviewCasesAsync",
                                pathTemplate: "\"/v1/compliance/review/cases\"",
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
                                operationId: "BetaListReviewCases",
                                methodName: "BetaListReviewCasesAsync",
                                pathTemplate: "\"/v1/compliance/review/cases\"",
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
                                operationId: "BetaListReviewCases",
                                methodName: "BetaListReviewCasesAsync",
                                pathTemplate: "\"/v1/compliance/review/cases\"",
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
                ProcessBetaListReviewCasesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaListReviewCases",
                                methodName: "BetaListReviewCasesAsync",
                                pathTemplate: "\"/v1/compliance/review/cases\"",
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
                                operationId: "BetaListReviewCases",
                                methodName: "BetaListReviewCasesAsync",
                                pathTemplate: "\"/v1/compliance/review/cases\"",
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
                                        __value_400 = __content_400 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = __content_400 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 is { Length: > 0 } ? __content_400 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 is { Length: > 0 } ? __content_401 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_403 = __content_403 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = __content_403 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 is { Length: > 0 } ? __content_403 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_404 = __content_404 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = __content_404 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 is { Length: > 0 } ? __content_404 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_408 = __content_408 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_408 = __content_408 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_408 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_408 is { Length: > 0 } ? __content_408 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_409 = __content_409 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = __content_409 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_409 is { Length: > 0 } ? __content_409 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_412 = __content_412 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_412, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_412 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_412 = __content_412 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_412, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_412 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_412 is { Length: > 0 } ? __content_412 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_413 = __content_413 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = __content_413 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 is { Length: > 0 } ? __content_413 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_429 = __content_429 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = __content_429 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 is { Length: > 0 } ? __content_429 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_431 = __content_431 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_431, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_431 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_431 = __content_431 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_431, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_431 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_431 is { Length: > 0 } ? __content_431 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_499 = __content_499 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_499, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_499 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_499 = __content_499 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_499, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_499 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_499 is { Length: > 0 } ? __content_499 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_500 = __content_500 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = __content_500 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 is { Length: > 0 } ? __content_500 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_501 = __content_501 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_501, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_501 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_501 = __content_501 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_501, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_501 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_501 is { Length: > 0 } ? __content_501 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_503 = __content_503 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = __content_503 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 is { Length: > 0 } ? __content_503 : __response.ReasonPhrase ?? string.Empty,
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
                                        __value_504 = __content_504 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_504, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_504 = __content_504 is not { Length: > 0 } ? null : global::Anthropic.BetaErrorResponse.FromJson(__content_504, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_504 = __ex;
                                }


                                throw global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_504 is { Length: > 0 } ? __content_504 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_504,
                                    responseBody: __content_504,
                                    responseObject: __value_504,
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
                                ProcessBetaListReviewCasesResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaListReviewCasesResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListReviewCasesResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Anthropic.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Anthropic.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
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

                                    var __value = await global::Anthropic.BetaListReviewCasesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListReviewCasesResponse>(
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
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
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
        /// Wraps BetaListReviewCasesAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaComplianceReviewCase&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="status">
        /// A review case status to filter by: `open` or `closed`.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="limit"></param>
        /// <param name="orderBy">
        /// The field that a list of review cases is sorted by: `created_at` or `updated_at`.
        /// </param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaComplianceReviewCase> BetaListReviewCasesAutoPagingAsync(
              string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaComplianceReviewCaseStatusFilter? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            string? userProfileId = default,
            int? limit = default,
            global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Anthropic.AutoSDKPager.CursorAsync<global::Anthropic.BetaListReviewCasesResponse, global::Anthropic.BetaComplianceReviewCase>(
                fetchPage: (__cursor, __ct) => BetaListReviewCasesAsync(
                    anthropicVersion: anthropicVersion,
                    anthropicBeta: anthropicBeta,
                    status: status,
                    createdAtGte: createdAtGte,
                    createdAtGt: createdAtGt,
                    createdAtLte: createdAtLte,
                    createdAtLt: createdAtLt,
                    updatedAtGte: updatedAtGte,
                    updatedAtGt: updatedAtGt,
                    updatedAtLte: updatedAtLte,
                    updatedAtLt: updatedAtLt,
                    userProfileId: userProfileId,
                    limit: limit,
                    page: __cursor,
                    orderBy: orderBy,
                    order: order,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Anthropic.BetaComplianceReviewCase>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPage,
                initialCursor: page,
                cancellationToken: cancellationToken);
        }

    }
}