#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Validate Plugin Marketplace Repository<br/>
        /// Check whether a plugin marketplace held in a public GitHub repository would<br/>
        /// synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a `.zip` of the marketplace directory instead, use Validate Plugin Marketplace Archive.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. A repository that is missing, private, or has no such branch or commit is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
        /// are fetched anonymously from GitHub, so a private one is reported as not found; a<br/>
        /// source on any other host is not fetched here, and the report notes that it will be<br/>
        /// checked when the marketplace actually synchronizes.<br/>
        /// Nothing is recorded on the Compliance API activity feed.<br/>
        /// For a worked example, see [Validate marketplace content](/docs/en/manage-claude/plugins-api#validate-marketplace-content)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `write:plugins` scope; `read:org_audit` and `read:compliance_org_data` do not grant it.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginMarketplaceValidationReport> BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostAsync(

            global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Plugin Marketplace Repository<br/>
        /// Check whether a plugin marketplace held in a public GitHub repository would<br/>
        /// synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a `.zip` of the marketplace directory instead, use Validate Plugin Marketplace Archive.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. A repository that is missing, private, or has no such branch or commit is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
        /// are fetched anonymously from GitHub, so a private one is reported as not found; a<br/>
        /// source on any other host is not fetched here, and the report notes that it will be<br/>
        /// checked when the marketplace actually synchronizes.<br/>
        /// Nothing is recorded on the Compliance API activity feed.<br/>
        /// For a worked example, see [Validate marketplace content](/docs/en/manage-claude/plugins-api#validate-marketplace-content)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `write:plugins` scope; `read:org_audit` and `read:compliance_org_data` do not grant it.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginMarketplaceValidationReport>> BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostAsResponseAsync(

            global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Plugin Marketplace Repository<br/>
        /// Check whether a plugin marketplace held in a public GitHub repository would<br/>
        /// synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a `.zip` of the marketplace directory instead, use Validate Plugin Marketplace Archive.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. A repository that is missing, private, or has no such branch or commit is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
        /// are fetched anonymously from GitHub, so a private one is reported as not found; a<br/>
        /// source on any other host is not fetched here, and the report notes that it will be<br/>
        /// checked when the marketplace actually synchronizes.<br/>
        /// Nothing is recorded on the Compliance API activity feed.<br/>
        /// For a worked example, see [Validate marketplace content](/docs/en/manage-claude/plugins-api#validate-marketplace-content)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `write:plugins` scope; `read:org_audit` and `read:compliance_org_data` do not grant it.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="ref">
        /// The branch to validate the tip of, or the full 40-character SHA of the commit to validate. When omitted, the branch a synchronization would read (usually the repository's default branch); if that is not the default branch, the report's `ref` says which branch was read. An empty string, a value longer than 255 characters, or one that contains `..` or a character other than ASCII letters, digits, `.`, `_`, `-`, `+`, and `/`, is a 400. Any other value that is not a 40-character SHA is read as a branch name; if the repository has no such branch, the response is a report with `valid: false`, not a 400.
        /// </param>
        /// <param name="repositoryUrl">
        /// The `https://` URL of a public repository on github.com that holds the marketplace. A URL longer than 2,048 characters, on any other host or scheme, with a port other than 443 or 80, with credentials in it, or that does not name exactly `owner/repo` (a trailing `.git` or `/` is accepted) is a 400. A private or missing repository is reported in the response, not refused.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginMarketplaceValidationReport> BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostAsync(
            string repositoryUrl,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? @ref = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}