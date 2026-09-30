#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Validate Plugin Marketplace Archive<br/>
        /// Check whether a plugin marketplace, uploaded as a `.zip` of the marketplace<br/>
        /// directory, would synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a public GitHub repository instead, use Validate Plugin Marketplace Repository.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. An archive that cannot be read as a marketplace is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginMarketplaceValidationReport> BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostAsync(

            global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Plugin Marketplace Archive<br/>
        /// Check whether a plugin marketplace, uploaded as a `.zip` of the marketplace<br/>
        /// directory, would synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a public GitHub repository instead, use Validate Plugin Marketplace Repository.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. An archive that cannot be read as a marketplace is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginMarketplaceValidationReport>> BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostAsResponseAsync(

            global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Plugin Marketplace Archive<br/>
        /// Check whether a plugin marketplace, uploaded as a `.zip` of the marketplace<br/>
        /// directory, would synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a public GitHub repository instead, use Validate Plugin Marketplace Repository.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. An archive that cannot be read as a marketplace is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
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
        /// <param name="archive">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
        /// <param name="archivename">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginMarketplaceValidationReport> BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostAsync(
            byte[] archive,
            string archivename,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Validate Plugin Marketplace Archive<br/>
        /// Check whether a plugin marketplace, uploaded as a `.zip` of the marketplace<br/>
        /// directory, would synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a public GitHub repository instead, use Validate Plugin Marketplace Repository.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. An archive that cannot be read as a marketplace is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
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
        /// <param name="archive">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
        /// <param name="archivename">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginMarketplaceValidationReport> BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostAsync(
            global::System.IO.Stream archive,
            string archivename,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Plugin Marketplace Archive<br/>
        /// Check whether a plugin marketplace, uploaded as a `.zip` of the marketplace<br/>
        /// directory, would synchronize into claude.ai, without connecting or storing it.<br/>
        /// To check a public GitHub repository instead, use Validate Plugin Marketplace Repository.<br/>
        /// The report says whether `marketplace.json` is well-formed, which plugins a<br/>
        /// synchronization would skip and why, and which plugins would synchronize only in<br/>
        /// part, with some files left out. An archive that cannot be read as a marketplace is reported, not refused: the response is a report with `valid: false`. Plugin sources outside the marketplace<br/>
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
        /// <param name="archive">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
        /// <param name="archivename">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginMarketplaceValidationReport>> BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostAsResponseAsync(
            global::System.IO.Stream archive,
            string archivename,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}