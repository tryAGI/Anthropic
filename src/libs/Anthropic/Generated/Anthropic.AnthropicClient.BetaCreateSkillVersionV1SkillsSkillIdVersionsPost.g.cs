
#nullable enable

namespace Anthropic
{
    public partial class AnthropicClient
    {
        partial void PrepareBetaCreateSkillVersionV1SkillsSkillIdVersionsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string skillId,
            ref string? anthropicBeta,
            ref string? anthropicVersion,
            global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost request);
        partial void PrepareBetaCreateSkillVersionV1SkillsSkillIdVersionsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string skillId,
            string? anthropicBeta,
            string? anthropicVersion,
            global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost request);
        partial void ProcessBetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Skill Version
        /// </summary>
        /// <param name="skillId">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaCreateSkillVersionResponse> BetaCreateSkillVersionV1SkillsSkillIdVersionsPostAsync(
            string skillId,
            global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareBetaCreateSkillVersionV1SkillsSkillIdVersionsPostArguments(
                httpClient: HttpClient,
                skillId: ref skillId,
                anthropicBeta: ref anthropicBeta,
                anthropicVersion: ref anthropicVersion,
                request: request);

            var __pathBuilder = new global::Anthropic.PathBuilder(
                path: $"/v1/skills/{skillId}/versions?beta=true",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{skillId}"),
                name: "skill_id");
            if (anthropicBeta != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{anthropicBeta}"),
                    name: "anthropic-beta");
            } 
            if (anthropicVersion != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{anthropicVersion}"),
                    name: "anthropic-version");
            } 
            if (request.Files != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Files, x => x))}]"),
                    name: "files");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareBetaCreateSkillVersionV1SkillsSkillIdVersionsPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                skillId: skillId,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessBetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error response.  See our [errors documentation](https://docs.claude.com/en/api/errors) for more details.
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::System.Exception? __exception_4XX = null;
                global::Anthropic.BetaErrorResponse? __value_4XX = null;
                try
                {
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
                }
                catch (global::System.Exception __ex)
                {
                    __exception_4XX = __ex;
                }

                throw new global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_4XX,
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
                ProcessBetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Anthropic.BetaCreateSkillVersionResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Anthropic.BetaCreateSkillVersionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Create Skill Version
        /// </summary>
        /// <param name="skillId">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="files">
        /// Files to upload for the skill.<br/>
        /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaCreateSkillVersionResponse> BetaCreateSkillVersionV1SkillsSkillIdVersionsPostAsync(
            string skillId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<byte[]>? files = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost
            {
                Files = files,
            };

            return await BetaCreateSkillVersionV1SkillsSkillIdVersionsPostAsync(
                skillId: skillId,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}