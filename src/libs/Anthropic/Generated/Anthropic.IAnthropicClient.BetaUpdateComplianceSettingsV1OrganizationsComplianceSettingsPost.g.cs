#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Compliance Settings<br/>
        /// Update your organization's Compliance Settings.<br/>
        /// Setting `state` to `enabled` turns on the Compliance API and begins<br/>
        /// capturing organization activity events. Setting it to `disabled` turns<br/>
        /// both off. `state` reflects whether the Compliance API is enabled.<br/>
        /// A request that sets `state` to its current value succeeds and leaves the<br/>
        /// resource unchanged. A `disabled` request stays in effect until a later<br/>
        /// `enabled` request or the organization's next provisioning action that<br/>
        /// enables Access Transparency: enabling Access Transparency also enables<br/>
        /// the Compliance API, which serves its activity events, so such<br/>
        /// provisioning (including re-runs) re-enables the Compliance API even<br/>
        /// after a `disabled` request. Automated provisioning never disables<br/>
        /// compliance settings.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaComplianceSettings> BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostAsync(

            global::Anthropic.BetaComplianceSettingsUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Compliance Settings<br/>
        /// Update your organization's Compliance Settings.<br/>
        /// Setting `state` to `enabled` turns on the Compliance API and begins<br/>
        /// capturing organization activity events. Setting it to `disabled` turns<br/>
        /// both off. `state` reflects whether the Compliance API is enabled.<br/>
        /// A request that sets `state` to its current value succeeds and leaves the<br/>
        /// resource unchanged. A `disabled` request stays in effect until a later<br/>
        /// `enabled` request or the organization's next provisioning action that<br/>
        /// enables Access Transparency: enabling Access Transparency also enables<br/>
        /// the Compliance API, which serves its activity events, so such<br/>
        /// provisioning (including re-runs) re-enables the Compliance API even<br/>
        /// after a `disabled` request. Automated provisioning never disables<br/>
        /// compliance settings.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaComplianceSettings>> BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostAsResponseAsync(

            global::Anthropic.BetaComplianceSettingsUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Compliance Settings<br/>
        /// Update your organization's Compliance Settings.<br/>
        /// Setting `state` to `enabled` turns on the Compliance API and begins<br/>
        /// capturing organization activity events. Setting it to `disabled` turns<br/>
        /// both off. `state` reflects whether the Compliance API is enabled.<br/>
        /// A request that sets `state` to its current value succeeds and leaves the<br/>
        /// resource unchanged. A `disabled` request stays in effect until a later<br/>
        /// `enabled` request or the organization's next provisioning action that<br/>
        /// enables Access Transparency: enabling Access Transparency also enables<br/>
        /// the Compliance API, which serves its activity events, so such<br/>
        /// provisioning (including re-runs) re-enables the Compliance API even<br/>
        /// after a `disabled` request. Automated provisioning never disables<br/>
        /// compliance settings.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="state">
        /// Desired state. Accepts the string shorthand "enabled" or "disabled" in place of the object form; the response always returns the canonical object form.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaComplianceSettings> BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostAsync(
            global::Anthropic.State2 state,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}