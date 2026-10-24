#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Slack Workspaces<br/>
        /// List the set-up Slack workspaces the organization owns, newest first by `created_at`. Pass `slack_workspace_id` to look one workspace up by its Slack identifier: `data` then holds that workspace, or is empty when it is not set up. A workspace of a Slack Enterprise Grid the organization has connected returns 404 until it is set up. With `include_inherited=true` each workspace's `settings` holds what applies in it, and the request fails with 503 rather than resolve against a settings level that could not be read. A `page` cursor resumes only a request with the same `include_inherited`.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="slackWorkspaceId"></param>
        /// <param name="includeInherited"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeTagListSlackWorkspacesResponse> BetaListSlackWorkspacesAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? slackWorkspaceId = default,
            bool? includeInherited = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Slack Workspaces<br/>
        /// List the set-up Slack workspaces the organization owns, newest first by `created_at`. Pass `slack_workspace_id` to look one workspace up by its Slack identifier: `data` then holds that workspace, or is empty when it is not set up. A workspace of a Slack Enterprise Grid the organization has connected returns 404 until it is set up. With `include_inherited=true` each workspace's `settings` holds what applies in it, and the request fails with 503 rather than resolve against a settings level that could not be read. A `page` cursor resumes only a request with the same `include_inherited`.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="slackWorkspaceId"></param>
        /// <param name="includeInherited"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaClaudeTagListSlackWorkspacesResponse>> BetaListSlackWorkspacesAsResponseAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? slackWorkspaceId = default,
            bool? includeInherited = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListSlackWorkspacesAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaClaudeTagSlackWorkspace&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="slackWorkspaceId"></param>
        /// <param name="includeInherited"></param>
        /// <param name="limit"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaClaudeTagSlackWorkspace> BetaListSlackWorkspacesAutoPagingAsync(
              string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? slackWorkspaceId = default,
            bool? includeInherited = default,
            int? limit = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}