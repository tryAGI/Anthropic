#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Plugin<br/>
        /// Create an organization-owned Plugin and its first version by uploading the<br/>
        /// version's files.<br/>
        /// The upload is `multipart/form-data`: the version's files (`files`, each part sent<br/>
        /// as `files[]`), with an optional `marketplace_id` and `release_notes`. The manifest's `name` becomes the<br/>
        /// Plugin's `name`, and `display_name`, `description` and `manifest_version` come<br/>
        /// from the manifest too.<br/>
        /// `name` may contain lowercase letters (from any alphabet), digits, and hyphens, up<br/>
        /// to 64 characters. Uppercase letters, spaces, underscores, and other punctuation are<br/>
        /// rejected.<br/>
        /// The `name` must be unique within the marketplace: a name already taken<br/>
        /// returns a 409 with `error_code` `plugin_name_taken` and, when a Plugin holds it,<br/>
        /// that Plugin's ID in `details.plugin_id`. A Plugin going into the organization's<br/>
        /// library marketplace is also refused with a 409 when one of its skills has the name of<br/>
        /// an organization skill (a skill an administrator uploaded for the whole organization<br/>
        /// in claude.ai): `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`; rename the skill, or remove the organization skill in<br/>
        /// claude.ai. A 503 with `error_code`<br/>
        /// `registration_pending` means the Plugin and its version were stored (their IDs are<br/>
        /// in `details`) but are not yet usable in claude.ai: do not retry the create (the<br/>
        /// retry would return `plugin_name_taken`); create a version on the stored Plugin<br/>
        /// instead, which completes it.<br/>
        /// For a worked example, see [Create a plugin](/docs/en/manage-claude/plugins-api#create-a-plugin)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPlugin> BetaCreatePluginV1OrganizationsPluginsPostAsync(

            global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Plugin<br/>
        /// Create an organization-owned Plugin and its first version by uploading the<br/>
        /// version's files.<br/>
        /// The upload is `multipart/form-data`: the version's files (`files`, each part sent<br/>
        /// as `files[]`), with an optional `marketplace_id` and `release_notes`. The manifest's `name` becomes the<br/>
        /// Plugin's `name`, and `display_name`, `description` and `manifest_version` come<br/>
        /// from the manifest too.<br/>
        /// `name` may contain lowercase letters (from any alphabet), digits, and hyphens, up<br/>
        /// to 64 characters. Uppercase letters, spaces, underscores, and other punctuation are<br/>
        /// rejected.<br/>
        /// The `name` must be unique within the marketplace: a name already taken<br/>
        /// returns a 409 with `error_code` `plugin_name_taken` and, when a Plugin holds it,<br/>
        /// that Plugin's ID in `details.plugin_id`. A Plugin going into the organization's<br/>
        /// library marketplace is also refused with a 409 when one of its skills has the name of<br/>
        /// an organization skill (a skill an administrator uploaded for the whole organization<br/>
        /// in claude.ai): `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`; rename the skill, or remove the organization skill in<br/>
        /// claude.ai. A 503 with `error_code`<br/>
        /// `registration_pending` means the Plugin and its version were stored (their IDs are<br/>
        /// in `details`) but are not yet usable in claude.ai: do not retry the create (the<br/>
        /// retry would return `plugin_name_taken`); create a version on the stored Plugin<br/>
        /// instead, which completes it.<br/>
        /// For a worked example, see [Create a plugin](/docs/en/manage-claude/plugins-api#create-a-plugin)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPlugin>> BetaCreatePluginV1OrganizationsPluginsPostAsResponseAsync(

            global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Plugin<br/>
        /// Create an organization-owned Plugin and its first version by uploading the<br/>
        /// version's files.<br/>
        /// The upload is `multipart/form-data`: the version's files (`files`, each part sent<br/>
        /// as `files[]`), with an optional `marketplace_id` and `release_notes`. The manifest's `name` becomes the<br/>
        /// Plugin's `name`, and `display_name`, `description` and `manifest_version` come<br/>
        /// from the manifest too.<br/>
        /// `name` may contain lowercase letters (from any alphabet), digits, and hyphens, up<br/>
        /// to 64 characters. Uppercase letters, spaces, underscores, and other punctuation are<br/>
        /// rejected.<br/>
        /// The `name` must be unique within the marketplace: a name already taken<br/>
        /// returns a 409 with `error_code` `plugin_name_taken` and, when a Plugin holds it,<br/>
        /// that Plugin's ID in `details.plugin_id`. A Plugin going into the organization's<br/>
        /// library marketplace is also refused with a 409 when one of its skills has the name of<br/>
        /// an organization skill (a skill an administrator uploaded for the whole organization<br/>
        /// in claude.ai): `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`; rename the skill, or remove the organization skill in<br/>
        /// claude.ai. A 503 with `error_code`<br/>
        /// `registration_pending` means the Plugin and its version were stored (their IDs are<br/>
        /// in `details`) but are not yet usable in claude.ai: do not retry the create (the<br/>
        /// retry would return `plugin_name_taken`); create a version on the stored Plugin<br/>
        /// instead, which completes it.<br/>
        /// For a worked example, see [Create a plugin](/docs/en/manage-claude/plugins-api#create-a-plugin)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="files">
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </param>
        /// <param name="marketplaceId">
        /// ID of the organization-owned plugin marketplace to create the Plugin in (prefixed `marketplace_`). It must be a `manual` marketplace, one whose Plugins are uploaded rather than synchronized from a repository. When omitted, the Plugin is created in the organization's library marketplace, an organization-owned `manual` marketplace created on first use.
        /// </param>
        /// <param name="releaseNotes">
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPlugin> BetaCreatePluginV1OrganizationsPluginsPostAsync(
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? marketplaceId = default,
            string? releaseNotes = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Plugin<br/>
        /// Create an organization-owned Plugin and its first version by uploading the<br/>
        /// version's files.<br/>
        /// The upload is `multipart/form-data`: the version's files (`files`, each part sent<br/>
        /// as `files[]`), with an optional `marketplace_id` and `release_notes`. The manifest's `name` becomes the<br/>
        /// Plugin's `name`, and `display_name`, `description` and `manifest_version` come<br/>
        /// from the manifest too.<br/>
        /// `name` may contain lowercase letters (from any alphabet), digits, and hyphens, up<br/>
        /// to 64 characters. Uppercase letters, spaces, underscores, and other punctuation are<br/>
        /// rejected.<br/>
        /// The `name` must be unique within the marketplace: a name already taken<br/>
        /// returns a 409 with `error_code` `plugin_name_taken` and, when a Plugin holds it,<br/>
        /// that Plugin's ID in `details.plugin_id`. A Plugin going into the organization's<br/>
        /// library marketplace is also refused with a 409 when one of its skills has the name of<br/>
        /// an organization skill (a skill an administrator uploaded for the whole organization<br/>
        /// in claude.ai): `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`; rename the skill, or remove the organization skill in<br/>
        /// claude.ai. A 503 with `error_code`<br/>
        /// `registration_pending` means the Plugin and its version were stored (their IDs are<br/>
        /// in `details`) but are not yet usable in claude.ai: do not retry the create (the<br/>
        /// retry would return `plugin_name_taken`); create a version on the stored Plugin<br/>
        /// instead, which completes it.<br/>
        /// For a worked example, see [Create a plugin](/docs/en/manage-claude/plugins-api#create-a-plugin)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="files">
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="marketplaceId">
        /// ID of the organization-owned plugin marketplace to create the Plugin in (prefixed `marketplace_`). It must be a `manual` marketplace, one whose Plugins are uploaded rather than synchronized from a repository. When omitted, the Plugin is created in the organization's library marketplace, an organization-owned `manual` marketplace created on first use.
        /// </param>
        /// <param name="releaseNotes">
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPlugin> BetaCreatePluginV1OrganizationsPluginsPostAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            string? marketplaceId = default,
            string? releaseNotes = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Plugin<br/>
        /// Create an organization-owned Plugin and its first version by uploading the<br/>
        /// version's files.<br/>
        /// The upload is `multipart/form-data`: the version's files (`files`, each part sent<br/>
        /// as `files[]`), with an optional `marketplace_id` and `release_notes`. The manifest's `name` becomes the<br/>
        /// Plugin's `name`, and `display_name`, `description` and `manifest_version` come<br/>
        /// from the manifest too.<br/>
        /// `name` may contain lowercase letters (from any alphabet), digits, and hyphens, up<br/>
        /// to 64 characters. Uppercase letters, spaces, underscores, and other punctuation are<br/>
        /// rejected.<br/>
        /// The `name` must be unique within the marketplace: a name already taken<br/>
        /// returns a 409 with `error_code` `plugin_name_taken` and, when a Plugin holds it,<br/>
        /// that Plugin's ID in `details.plugin_id`. A Plugin going into the organization's<br/>
        /// library marketplace is also refused with a 409 when one of its skills has the name of<br/>
        /// an organization skill (a skill an administrator uploaded for the whole organization<br/>
        /// in claude.ai): `error_code` `skill_name_taken`, with that name in<br/>
        /// `details.skill_name`; rename the skill, or remove the organization skill in<br/>
        /// claude.ai. A 503 with `error_code`<br/>
        /// `registration_pending` means the Plugin and its version were stored (their IDs are<br/>
        /// in `details`) but are not yet usable in claude.ai: do not retry the create (the<br/>
        /// retry would return `plugin_name_taken`); create a version on the stored Plugin<br/>
        /// instead, which completes it.<br/>
        /// For a worked example, see [Create a plugin](/docs/en/manage-claude/plugins-api#create-a-plugin)<br/>
        /// in the Plugins API guide.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="files">
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="marketplaceId">
        /// ID of the organization-owned plugin marketplace to create the Plugin in (prefixed `marketplace_`). It must be a `manual` marketplace, one whose Plugins are uploaded rather than synchronized from a repository. When omitted, the Plugin is created in the organization's library marketplace, an organization-owned `manual` marketplace created on first use.
        /// </param>
        /// <param name="releaseNotes">
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPlugin>> BetaCreatePluginV1OrganizationsPluginsPostAsResponseAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            string? marketplaceId = default,
            string? releaseNotes = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}