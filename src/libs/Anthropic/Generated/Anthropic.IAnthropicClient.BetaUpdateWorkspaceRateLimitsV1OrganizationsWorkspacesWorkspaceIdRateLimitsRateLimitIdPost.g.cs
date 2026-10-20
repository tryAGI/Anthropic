#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Set Workspace Rate Limits<br/>
        /// Set or clear rate-limit overrides for one rate-limit group in a workspace.<br/>
        /// Only the limiter types named in `limits` change: an integer `value` sets<br/>
        /// that type's override and `null` clears it. Types not named keep their<br/>
        /// current value. A value above the organization's own limit is stored, but<br/>
        /// the organization limit still applies, so the lower of the two is<br/>
        /// enforced.<br/>
        /// Returns the targeted group's entry with this request applied, in the shape<br/>
        /// `GET /v1/organizations/workspaces/{workspace_id}/rate_limits` returns.<br/>
        /// Changes take effect within about an hour.
        /// </summary>
        /// <param name="rateLimitId">
        /// The `id` of the organization's rate-limit entry to set overrides for.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspaceRateLimit> BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostAsync(
            string rateLimitId,
            string workspaceId,

            global::Anthropic.BetaWorkspaceRateLimitUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Workspace Rate Limits<br/>
        /// Set or clear rate-limit overrides for one rate-limit group in a workspace.<br/>
        /// Only the limiter types named in `limits` change: an integer `value` sets<br/>
        /// that type's override and `null` clears it. Types not named keep their<br/>
        /// current value. A value above the organization's own limit is stored, but<br/>
        /// the organization limit still applies, so the lower of the two is<br/>
        /// enforced.<br/>
        /// Returns the targeted group's entry with this request applied, in the shape<br/>
        /// `GET /v1/organizations/workspaces/{workspace_id}/rate_limits` returns.<br/>
        /// Changes take effect within about an hour.
        /// </summary>
        /// <param name="rateLimitId">
        /// The `id` of the organization's rate-limit entry to set overrides for.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaWorkspaceRateLimit>> BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostAsResponseAsync(
            string rateLimitId,
            string workspaceId,

            global::Anthropic.BetaWorkspaceRateLimitUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Workspace Rate Limits<br/>
        /// Set or clear rate-limit overrides for one rate-limit group in a workspace.<br/>
        /// Only the limiter types named in `limits` change: an integer `value` sets<br/>
        /// that type's override and `null` clears it. Types not named keep their<br/>
        /// current value. A value above the organization's own limit is stored, but<br/>
        /// the organization limit still applies, so the lower of the two is<br/>
        /// enforced.<br/>
        /// Returns the targeted group's entry with this request applied, in the shape<br/>
        /// `GET /v1/organizations/workspaces/{workspace_id}/rate_limits` returns.<br/>
        /// Changes take effect within about an hour.
        /// </summary>
        /// <param name="rateLimitId">
        /// The `id` of the organization's rate-limit entry to set overrides for.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="limits">
        /// Limits to set or clear. Unspecified limit types are unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspaceRateLimit> BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostAsync(
            string rateLimitId,
            string workspaceId,
            global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue> limits,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}