#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Partially update a federation issuer.<br/>
        /// Setting `jwks` replaces the full JWKS shape at once. Archived issuers<br/>
        /// cannot be updated; this returns 400. Create a new issuer instead.<br/>
        /// Updating an issuer that backs a rule with a scope outside<br/>
        /// `workspace:developer` or `workspace:inference` requires a Console<br/>
        /// session.
        /// </summary>
        /// <param name="federationIssuerId">
        /// ID of the federation issuer to update.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationIssuer> BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostAsync(
            string federationIssuerId,

            global::Anthropic.BetaFederationIssuerUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Partially update a federation issuer.<br/>
        /// Setting `jwks` replaces the full JWKS shape at once. Archived issuers<br/>
        /// cannot be updated; this returns 400. Create a new issuer instead.<br/>
        /// Updating an issuer that backs a rule with a scope outside<br/>
        /// `workspace:developer` or `workspace:inference` requires a Console<br/>
        /// session.
        /// </summary>
        /// <param name="federationIssuerId">
        /// ID of the federation issuer to update.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFederationIssuer>> BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostAsResponseAsync(
            string federationIssuerId,

            global::Anthropic.BetaFederationIssuerUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Partially update a federation issuer.<br/>
        /// Setting `jwks` replaces the full JWKS shape at once. Archived issuers<br/>
        /// cannot be updated; this returns 400. Create a new issuer instead.<br/>
        /// Updating an issuer that backs a rule with a scope outside<br/>
        /// `workspace:developer` or `workspace:inference` requires a Console<br/>
        /// session.
        /// </summary>
        /// <param name="federationIssuerId">
        /// ID of the federation issuer to update.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="checkJti">
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </param>
        /// <param name="issuerUrl">
        /// Replaces the `iss` claim value to match against. For discovery-mode issuers without a `discovery_base`, this is also the URL Anthropic fetches the OIDC discovery document and signing keys from, so changing it repoints the JWKS source. Changing the issuer URL to a well-known shared platform is rejected while any live rule under this issuer would not constrain tenant identity.
        /// </param>
        /// <param name="jwks">
        /// Replaces the entire JWKS configuration.
        /// </param>
        /// <param name="jwksPollingDisabled">
        /// Only `false` is accepted, to re-enable polling after the system pauses it. Polling is paused automatically; sending `true` is rejected.
        /// </param>
        /// <param name="maxJwtLifetimeSeconds">
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </param>
        /// <param name="name">
        /// Replaces the slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationIssuer> BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostAsync(
            string federationIssuerId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            bool? checkJti = default,
            string? issuerUrl = default,
            global::Anthropic.JwksVariant1? jwks = default,
            bool? jwksPollingDisabled = default,
            int? maxJwtLifetimeSeconds = default,
            string? name = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}