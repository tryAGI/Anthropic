#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update External Key<br/>
        /// Partially update an external key config. Omitted fields are left unchanged.<br/>
        /// `display_name` is always editable. `geo` and `provider_config` cannot<br/>
        /// be changed once any workspace references this config, because previously<br/>
        /// encrypted data requires the original key identity to decrypt.
        /// </summary>
        /// <param name="externalKeyId">
        /// ID of the External Key.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalKey> BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostAsync(
            string externalKeyId,

            global::Anthropic.BetaExternalKeyUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update External Key<br/>
        /// Partially update an external key config. Omitted fields are left unchanged.<br/>
        /// `display_name` is always editable. `geo` and `provider_config` cannot<br/>
        /// be changed once any workspace references this config, because previously<br/>
        /// encrypted data requires the original key identity to decrypt.
        /// </summary>
        /// <param name="externalKeyId">
        /// ID of the External Key.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaExternalKey>> BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostAsResponseAsync(
            string externalKeyId,

            global::Anthropic.BetaExternalKeyUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update External Key<br/>
        /// Partially update an external key config. Omitted fields are left unchanged.<br/>
        /// `display_name` is always editable. `geo` and `provider_config` cannot<br/>
        /// be changed once any workspace references this config, because previously<br/>
        /// encrypted data requires the original key identity to decrypt.
        /// </summary>
        /// <param name="externalKeyId">
        /// ID of the External Key.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="displayName">
        /// Human-friendly display name.
        /// </param>
        /// <param name="geo">
        /// Data residency geo. Only `us` is supported.
        /// </param>
        /// <param name="providerConfig">
        /// KMS provider identity and auth coordinates.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalKey> BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostAsync(
            string externalKeyId,
            string? anthropicVersion = default,
            string? displayName = default,
            string? geo = default,
            global::Anthropic.ProviderConfigVariant1? providerConfig = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}