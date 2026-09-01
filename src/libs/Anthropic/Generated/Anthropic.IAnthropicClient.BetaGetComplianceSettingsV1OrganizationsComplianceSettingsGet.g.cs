#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Compliance Settings<br/>
        /// Retrieve your organization's Compliance Settings.<br/>
        /// Compliance Settings is a singleton resource: there is exactly one per<br/>
        /// organization, addressed without an identifier. The `state` field reflects<br/>
        /// whether the Compliance API is enabled. An organization with a parent<br/>
        /// organization reads the state inherited from the parent's configuration.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaComplianceSettings> BetaGetComplianceSettingsV1OrganizationsComplianceSettingsGetAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Compliance Settings<br/>
        /// Retrieve your organization's Compliance Settings.<br/>
        /// Compliance Settings is a singleton resource: there is exactly one per<br/>
        /// organization, addressed without an identifier. The `state` field reflects<br/>
        /// whether the Compliance API is enabled. An organization with a parent<br/>
        /// organization reads the state inherited from the parent's configuration.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaComplianceSettings>> BetaGetComplianceSettingsV1OrganizationsComplianceSettingsGetAsResponseAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}