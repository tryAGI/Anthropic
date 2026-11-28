#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspace> BetaCreateWorkspaceV1OrganizationsWorkspacesPostAsync(

            global::Anthropic.BetaWorkspaceCreateParams request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaWorkspace>> BetaCreateWorkspaceV1OrganizationsWorkspacesPostAsResponseAsync(

            global::Anthropic.BetaWorkspaceCreateParams request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="dataResidency">
        /// Data residency configuration for the workspace. If omitted, defaults to `workspace_geo: "us"`, `allowed_inference_geos: "unrestricted"`, and `default_inference_geo: "global"`.
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
        /// Where the Workspace's retained inference data and transcript copies go, and whether Anthropic's human review applies. Requires the `efs-2026-10-01` `anthropic-beta` value. When omitted, `safeguards_storage` and `transcripts_storage` are `internal` and `human_review` is `enabled`. Cannot be null. An Admin API key can't set this field, because it doesn't belong to a user or a service account. Use an API key that belongs to one, or an OAuth token.
        /// </param>
        /// <param name="name">
        /// Name of the Workspace.
        /// </param>
        /// <param name="tags">
        /// User-defined tags as string key-value pairs. Keys may not begin with `anthropic`.
        /// </param>
        /// <param name="userProfileId">
        /// ID of a user profile to attach to the Workspace. Every inference request through the Workspace must then name this user profile; the API rejects a request that names none or a different one. The user profile can't be replaced or removed later; only deleting the user profile clears it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspace> BetaCreateWorkspaceV1OrganizationsWorkspacesPostAsync(
            string name,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.BetaDataResidencyCreateParams? dataResidency = default,
            string? displayColor = default,
            string? externalKeyId = default,
            global::Anthropic.BetaInferenceDataPrivacyCreateParams? inferenceDataPrivacy = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            string? userProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}