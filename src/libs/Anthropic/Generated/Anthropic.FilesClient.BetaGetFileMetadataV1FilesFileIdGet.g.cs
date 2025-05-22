
#nullable enable

namespace Anthropic
{
    public partial class FilesClient
    {
        partial void PrepareBetaGetFileMetadataV1FilesFileIdGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fileId,
            ref string? anthropicBeta,
            ref string? anthropicVersion,
            ref string? xApiKey);
        partial void PrepareBetaGetFileMetadataV1FilesFileIdGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fileId,
            string? anthropicBeta,
            string? anthropicVersion,
            string? xApiKey);
        partial void ProcessBetaGetFileMetadataV1FilesFileIdGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaGetFileMetadataV1FilesFileIdGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get File Metadata
        /// </summary>
        /// <param name="fileId">
        /// ID of the File.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaFileMetadataSchema> BetaGetFileMetadataV1FilesFileIdGetAsync(
            string fileId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBetaGetFileMetadataV1FilesFileIdGetArguments(
                httpClient: HttpClient,
                fileId: ref fileId,
                anthropicBeta: ref anthropicBeta,
                anthropicVersion: ref anthropicVersion,
                xApiKey: ref xApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/files/{fileId}?beta=true",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareBetaGetFileMetadataV1FilesFileIdGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileId: fileId,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessBetaGetFileMetadataV1FilesFileIdGetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error response.  See our [errors documentation](https://docs.anthropic.com/en/api/errors) for more details.
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::Anthropic.BetaErrorResponse? __value_4XX = null;
                if (ReadResponseAsString)
                {
                    __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_4XX = global::Anthropic.BetaErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_4XX = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_4XX = await global::Anthropic.BetaErrorResponse.FromJsonStreamAsync(__contentStream_4XX, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessBetaGetFileMetadataV1FilesFileIdGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Anthropic.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Anthropic.BetaFileMetadataSchema.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Anthropic.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::Anthropic.BetaFileMetadataSchema.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}