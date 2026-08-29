#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Register an OIDC issuer that Anthropic will trust for workload identity<br/>
        /// federation in your organization.<br/>
        /// The `jwks` field controls how the issuer's signing keys are obtained and<br/>
        /// takes one of three shapes selected by `type`: `discovery` (resolve keys<br/>
        /// through OIDC discovery), `explicit_url` (fetch keys from a fixed JWKS<br/>
        /// URL), or `inline` (provide a static key set). When `jwks.type` is<br/>
        /// `discovery` and no `discovery_base` is set, the issuer URL must be<br/>
        /// publicly reachable over HTTPS so Anthropic can fetch the discovery<br/>
        /// document; for `explicit_url` and `inline` modes the issuer URL is only<br/>
        /// matched as the JWT's `iss` claim and is not fetched.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationIssuer> BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostAsync(

            global::Anthropic.BetaFederationIssuerCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Register an OIDC issuer that Anthropic will trust for workload identity<br/>
        /// federation in your organization.<br/>
        /// The `jwks` field controls how the issuer's signing keys are obtained and<br/>
        /// takes one of three shapes selected by `type`: `discovery` (resolve keys<br/>
        /// through OIDC discovery), `explicit_url` (fetch keys from a fixed JWKS<br/>
        /// URL), or `inline` (provide a static key set). When `jwks.type` is<br/>
        /// `discovery` and no `discovery_base` is set, the issuer URL must be<br/>
        /// publicly reachable over HTTPS so Anthropic can fetch the discovery<br/>
        /// document; for `explicit_url` and `inline` modes the issuer URL is only<br/>
        /// matched as the JWT's `iss` claim and is not fetched.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFederationIssuer>> BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostAsResponseAsync(

            global::Anthropic.BetaFederationIssuerCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Register an OIDC issuer that Anthropic will trust for workload identity<br/>
        /// federation in your organization.<br/>
        /// The `jwks` field controls how the issuer's signing keys are obtained and<br/>
        /// takes one of three shapes selected by `type`: `discovery` (resolve keys<br/>
        /// through OIDC discovery), `explicit_url` (fetch keys from a fixed JWKS<br/>
        /// URL), or `inline` (provide a static key set). When `jwks.type` is<br/>
        /// `discovery` and no `discovery_base` is set, the issuer URL must be<br/>
        /// publicly reachable over HTTPS so Anthropic can fetch the discovery<br/>
        /// document; for `explicit_url` and `inline` modes the issuer URL is only<br/>
        /// matched as the JWT's `iss` claim and is not fetched.
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="checkJti">
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Defaults to true. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </param>
        /// <param name="issuerUrl">
        /// The `iss` claim value to match against.
        /// </param>
        /// <param name="jwks">
        /// How signing keys are obtained. Defaults to OIDC discovery.
        /// </param>
        /// <param name="maxJwtLifetimeSeconds">
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Defaults to 3600 (1h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </param>
        /// <param name="name">
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationIssuer> BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostAsync(
            string issuerUrl,
            string name,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            bool? checkJti = default,
            global::Anthropic.Jwks2? jwks = default,
            int? maxJwtLifetimeSeconds = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}