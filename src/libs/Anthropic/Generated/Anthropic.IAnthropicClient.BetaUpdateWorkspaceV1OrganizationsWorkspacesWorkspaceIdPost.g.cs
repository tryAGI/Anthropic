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
        /// <param name="anthropicBeta">
        /// Optional. Send `efs-2026-10-01` in this header to use this endpoint's beta features: additional parameters, accepted values and response fields.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspace> BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostAsync(
            string workspaceId,

            global::Anthropic.BetaWorkspaceUpdateParams request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
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
        /// <param name="anthropicBeta">
        /// Optional. Send `efs-2026-10-01` in this header to use this endpoint's beta features: additional parameters, accepted values and response fields.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaWorkspace>> BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostAsResponseAsync(
            string workspaceId,

            global::Anthropic.BetaWorkspaceUpdateParams request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
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
        /// <param name="anthropicBeta">
        /// Optional. Send `efs-2026-10-01` in this header to use this endpoint's beta features: additional parameters, accepted values and response fields.
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
        /// Claude Platform on AWS the value for an AWS KMS key is the key's ARN, and your<br/>
        /// organization's own key must be a single-Region key in the same Region as the<br/>
        /// Workspace. If that key is outside the Workspace's AWS account, it can be attached<br/>
        /// only by updating an active Workspace. On that platform the key is validated<br/>
        /// against this Workspace when it is attached, so a key-policy problem is reported<br/>
        /// as an error on this request. This field is write-once: once a key is attached to<br/>
        /// a Workspace it cannot be detached or replaced. To rotate key material, rotate<br/>
        /// the underlying key on your cloud KMS; the `external_key_id` stays the same.
        /// </param>
        /// <param name="inferenceDataPrivacy">
        /// Changes to where the Workspace's retained inference data and transcript copies go, and to whether Anthropic's human review applies. Requires the `efs-2026-10-01` `anthropic-beta` value. An omitted member is unchanged. Cannot be null. An Admin API key can't set this field, because it doesn't belong to a user or a service account. Use an API key that belongs to one, or an OAuth token.
        /// </param>
        /// <param name="name">
        /// Name of the Workspace.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
        /// <param name="userProfileId">
        /// ID of a user profile to attach to the Workspace. Every inference request through the Workspace must then name this user profile; the API rejects a request that names none or a different one. Once set, it can't be replaced or removed (sending the same ID again changes nothing); only deleting the user profile clears it. It can't be set on a Workspace whose External Key isn't bound to this user profile. The default Workspace can't have a user profile.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspace> BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostAsync(
            string workspaceId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaDataResidencyUpdateParams? dataResidency = default,
            string? displayColor = default,
            string? externalKeyId = default,
            global::Anthropic.BetaInferenceDataPrivacyUpdateParams? inferenceDataPrivacy = default,
            string? name = default,
            object? tags = default,
            string? userProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}