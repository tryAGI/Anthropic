
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string federationRuleId,
            ref string workspaceId,
            ref string? anthropicBeta,
            ref string? xApiKey,
            ref string? anthropicVersion);
        partial void PrepareBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string federationRuleId,
            string workspaceId,
            string? anthropicBeta,
            string? xApiKey,
            string? anthropicVersion);
        partial void ProcessBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove Federation Rule Workspace<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Disable a federation rule for a workspace.<br/>
        /// Idempotent; succeeds even if the enablement was already removed. OAuth<br/>
        /// callers may only manage rules whose `oauth_scope` is<br/>
        /// `workspace:developer` or `workspace:inference`; other scopes require a<br/>
        /// Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace to disable for.
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
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse> BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsync(
            string federationRuleId,
            string workspaceId,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsResponseAsync(
                federationRuleId: federationRuleId,
                workspaceId: workspaceId,
                anthropicBeta: anthropicBeta,
                xApiKey: xApiKey,
                anthropicVersion: anthropicVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Remove Federation Rule Workspace<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Disable a federation rule for a workspace.<br/>
        /// Idempotent; succeeds even if the enablement was already removed. OAuth<br/>
        /// callers may only manage rules whose `oauth_scope` is<br/>
        /// `workspace:developer` or `workspace:inference`; other scopes require a<br/>
        /// Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace to disable for.
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
        public async global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse>> BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsResponseAsync(
            string federationRuleId,
            string workspaceId,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteArguments(
                httpClient: HttpClient,
                federationRuleId: ref federationRuleId,
                workspaceId: ref workspaceId,
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
                                path: $"/v1/organizations/federation_rules/{federationRuleId}/workspaces/{workspaceId}?beta=true",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Anthropic.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Delete,
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
                PrepareBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    federationRuleId: federationRuleId!,
                    workspaceId: workspaceId!,
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
                                operationId: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDelete",
                                methodName: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsync",
                                pathTemplate: "$\"/v1/organizations/federation_rules/{federationRuleId}/workspaces/{workspaceId}?beta=true\"",
                                httpMethod: "DELETE",
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
                                operationId: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDelete",
                                methodName: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsync",
                                pathTemplate: "$\"/v1/organizations/federation_rules/{federationRuleId}/workspaces/{workspaceId}?beta=true\"",
                                httpMethod: "DELETE",
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
                                operationId: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDelete",
                                methodName: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsync",
                                pathTemplate: "$\"/v1/organizations/federation_rules/{federationRuleId}/workspaces/{workspaceId}?beta=true\"",
                                httpMethod: "DELETE",
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
                ProcessBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Anthropic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Anthropic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDelete",
                                methodName: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsync",
                                pathTemplate: "$\"/v1/organizations/federation_rules/{federationRuleId}/workspaces/{workspaceId}?beta=true\"",
                                httpMethod: "DELETE",
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
                                operationId: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDelete",
                                methodName: "BetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteAsync",
                                pathTemplate: "$\"/v1/organizations/federation_rules/{federationRuleId}/workspaces/{workspaceId}?beta=true\"",
                                httpMethod: "DELETE",
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
                                ProcessBetaRemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse>(
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

                                    var __value = await global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse>(
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
    }
}