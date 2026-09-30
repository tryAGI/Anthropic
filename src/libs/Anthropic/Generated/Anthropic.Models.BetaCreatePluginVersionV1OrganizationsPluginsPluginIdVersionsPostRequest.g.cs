
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest
    {
        /// <summary>
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_notes")]
        public string? ReleaseNotes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// The version's files: one part per file, the part's filename being the file's path within the Plugin (for example `skills/review-pr/SKILL.md`), or a single `.zip` or `.plugin` archive holding them all. On the wire each part is named `files[]`, and a part named plain `files` is not read; with cURL, `-F 'files[]=@SKILL.md;filename=skills/review-pr/SKILL.md'`. The files must include the manifest, `.claude-plugin/plugin.json`.
        /// </param>
        /// <param name="releaseNotes">
        /// Release notes stored with the version and shown in its version history in claude.ai; up to 5,000 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest(
            global::System.Collections.Generic.IList<byte[]> files,
            string? releaseNotes)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.ReleaseNotes = releaseNotes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest" /> class.
        /// </summary>
        public BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest()
        {
        }

    }
}