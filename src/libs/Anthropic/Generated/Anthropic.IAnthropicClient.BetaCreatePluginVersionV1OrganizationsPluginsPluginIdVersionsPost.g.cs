#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Plugin Version<br/>
        /// Add a version to an organization-owned Plugin by uploading the new version's<br/>
        /// files; it becomes the version served to members unless the Plugin's served version<br/>
        /// has been pinned.<br/>
        /// The upload is the same `multipart/form-data` as creating a Plugin: the version's<br/>
        /// files (`files`, each part sent as `files[]`) and optional `release_notes`. The uploaded manifest's `name`<br/>
        /// must equal the Plugin's `name`. Returns the stored version; read the Plugin back to<br/>
        /// see which version it serves.<br/>
        /// Only a Plugin in a `manual` marketplace takes uploads; a Plugin synchronized from<br/>
        /// a repository gets its versions from the repository. When the Plugin is in the<br/>
        /// organization's library marketplace, a version that adds a skill with the name of an<br/>
        /// organization skill (a skill an administrator uploaded for the whole organization in<br/>
        /// claude.ai) is refused with a 409: `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`. A 503 with `error_code`<br/>
        /// `registration_pending` means the version was stored but is not yet usable; a later<br/>
        /// version create on the Plugin completes it.<br/>
        /// For a worked example, see [Create a version](/docs/en/manage-claude/plugins-api#create-a-version)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginVersion> BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostAsync(
            string pluginId,

            global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Plugin Version<br/>
        /// Add a version to an organization-owned Plugin by uploading the new version's<br/>
        /// files; it becomes the version served to members unless the Plugin's served version<br/>
        /// has been pinned.<br/>
        /// The upload is the same `multipart/form-data` as creating a Plugin: the version's<br/>
        /// files (`files`, each part sent as `files[]`) and optional `release_notes`. The uploaded manifest's `name`<br/>
        /// must equal the Plugin's `name`. Returns the stored version; read the Plugin back to<br/>
        /// see which version it serves.<br/>
        /// Only a Plugin in a `manual` marketplace takes uploads; a Plugin synchronized from<br/>
        /// a repository gets its versions from the repository. When the Plugin is in the<br/>
        /// organization's library marketplace, a version that adds a skill with the name of an<br/>
        /// organization skill (a skill an administrator uploaded for the whole organization in<br/>
        /// claude.ai) is refused with a 409: `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`. A 503 with `error_code`<br/>
        /// `registration_pending` means the version was stored but is not yet usable; a later<br/>
        /// version create on the Plugin completes it.<br/>
        /// For a worked example, see [Create a version](/docs/en/manage-claude/plugins-api#create-a-version)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginVersion>> BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostAsResponseAsync(
            string pluginId,

            global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Plugin Version<br/>
        /// Add a version to an organization-owned Plugin by uploading the new version's<br/>
        /// files; it becomes the version served to members unless the Plugin's served version<br/>
        /// has been pinned.<br/>
        /// The upload is the same `multipart/form-data` as creating a Plugin: the version's<br/>
        /// files (`files`, each part sent as `files[]`) and optional `release_notes`. The uploaded manifest's `name`<br/>
        /// must equal the Plugin's `name`. Returns the stored version; read the Plugin back to<br/>
        /// see which version it serves.<br/>
        /// Only a Plugin in a `manual` marketplace takes uploads; a Plugin synchronized from<br/>
        /// a repository gets its versions from the repository. When the Plugin is in the<br/>
        /// organization's library marketplace, a version that adds a skill with the name of an<br/>
        /// organization skill (a skill an administrator uploaded for the whole organization in<br/>
        /// claude.ai) is refused with a 409: `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`. A 503 with `error_code`<br/>
        /// `registration_pending` means the version was stored but is not yet usable; a later<br/>
        /// version create on the Plugin completes it.<br/>
        /// For a worked example, see [Create a version](/docs/en/manage-claude/plugins-api#create-a-version)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="files">
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </param>
        /// <param name="releaseNotes">
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginVersion> BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostAsync(
            string pluginId,
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? releaseNotes = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Plugin Version<br/>
        /// Add a version to an organization-owned Plugin by uploading the new version's<br/>
        /// files; it becomes the version served to members unless the Plugin's served version<br/>
        /// has been pinned.<br/>
        /// The upload is the same `multipart/form-data` as creating a Plugin: the version's<br/>
        /// files (`files`, each part sent as `files[]`) and optional `release_notes`. The uploaded manifest's `name`<br/>
        /// must equal the Plugin's `name`. Returns the stored version; read the Plugin back to<br/>
        /// see which version it serves.<br/>
        /// Only a Plugin in a `manual` marketplace takes uploads; a Plugin synchronized from<br/>
        /// a repository gets its versions from the repository. When the Plugin is in the<br/>
        /// organization's library marketplace, a version that adds a skill with the name of an<br/>
        /// organization skill (a skill an administrator uploaded for the whole organization in<br/>
        /// claude.ai) is refused with a 409: `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`. A 503 with `error_code`<br/>
        /// `registration_pending` means the version was stored but is not yet usable; a later<br/>
        /// version create on the Plugin completes it.<br/>
        /// For a worked example, see [Create a version](/docs/en/manage-claude/plugins-api#create-a-version)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="files">
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="releaseNotes">
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginVersion> BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostAsync(
            string pluginId,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            string? releaseNotes = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Plugin Version<br/>
        /// Add a version to an organization-owned Plugin by uploading the new version's<br/>
        /// files; it becomes the version served to members unless the Plugin's served version<br/>
        /// has been pinned.<br/>
        /// The upload is the same `multipart/form-data` as creating a Plugin: the version's<br/>
        /// files (`files`, each part sent as `files[]`) and optional `release_notes`. The uploaded manifest's `name`<br/>
        /// must equal the Plugin's `name`. Returns the stored version; read the Plugin back to<br/>
        /// see which version it serves.<br/>
        /// Only a Plugin in a `manual` marketplace takes uploads; a Plugin synchronized from<br/>
        /// a repository gets its versions from the repository. When the Plugin is in the<br/>
        /// organization's library marketplace, a version that adds a skill with the name of an<br/>
        /// organization skill (a skill an administrator uploaded for the whole organization in<br/>
        /// claude.ai) is refused with a 409: `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`. A 503 with `error_code`<br/>
        /// `registration_pending` means the version was stored but is not yet usable; a later<br/>
        /// version create on the Plugin completes it.<br/>
        /// For a worked example, see [Create a version](/docs/en/manage-claude/plugins-api#create-a-version)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="files">
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="releaseNotes">
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginVersion>> BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostAsResponseAsync(
            string pluginId,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            string? releaseNotes = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}