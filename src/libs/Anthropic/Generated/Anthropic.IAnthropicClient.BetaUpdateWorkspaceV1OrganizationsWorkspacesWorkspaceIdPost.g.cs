#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspace> BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostAsync(
            string workspaceId,

            global::Anthropic.BetaWorkspaceUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaWorkspace>> BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostAsResponseAsync(
            string workspaceId,

            global::Anthropic.BetaWorkspaceUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="dataResidency">
        /// Data residency configuration for the workspace.
        /// </param>
        /// <param name="displayColor">
        /// Hex color code representing the Workspace in the Anthropic Console.
        /// </param>
        /// <param name="externalKeyId">
        /// ID of the customer-managed encryption key (CMEK) configuration to use for this<br/>
        /// Workspace. Setting this field requires CMEK to be enabled for your<br/>
        /// organization. When set, data stored for this Workspace is encrypted with the<br/>
        /// referenced key. Create key configurations with the External Keys API. On<br/>
        /// Claude Platform on AWS the value is the AWS KMS key ARN, and the key must be a<br/>
        /// single-Region key in the same AWS account and Region as the Workspace. On that<br/>
        /// platform the key is validated against this Workspace when it is attached, so a<br/>
        /// key-policy problem is reported as an error on this request. This field is write-once:<br/>
        /// once a key is attached to a Workspace it cannot be detached or replaced. To<br/>
        /// rotate key material, rotate the underlying key on your cloud KMS; the<br/>
        /// `external_key_id` stays the same.
        /// </param>
        /// <param name="name">
        /// Name of the Workspace.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspace> BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostAsync(
            string workspaceId,
            string? anthropicVersion = default,
            global::Anthropic.BetaDataResidencyUpdateParams? dataResidency = default,
            string? displayColor = default,
            string? externalKeyId = default,
            string? name = default,
            object? tags = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}