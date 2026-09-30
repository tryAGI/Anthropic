
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The repository to validate: its URL, and optionally the branch or commit<br/>
    /// to read. `repository_url` is required and any other field is refused; a URL<br/>
    /// that is not a public github.com repository, or a `ref` that cannot be a<br/>
    /// branch name or commit SHA, is a 400 (see each field).
    /// </summary>
    public sealed partial class BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest
    {
        /// <summary>
        /// The branch to validate the tip of, or the full 40-character SHA of the commit to validate. When omitted, the branch a synchronization would read (usually the repository's default branch); if that is not the default branch, the report's `ref` says which branch was read. An empty string, or a value that is neither a branch name nor a 40-character SHA, is a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The `https://` URL of a public repository on github.com that holds the marketplace. Any other host, a URL with credentials in it, or one that does not name a repository is a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest" /> class.
        /// </summary>
        /// <param name="repositoryUrl">
        /// The `https://` URL of a public repository on github.com that holds the marketplace. Any other host, a URL with credentials in it, or one that does not name a repository is a 400.
        /// </param>
        /// <param name="ref">
        /// The branch to validate the tip of, or the full 40-character SHA of the commit to validate. When omitted, the branch a synchronization would read (usually the repository's default branch); if that is not the default branch, the report's `ref` says which branch was read. An empty string, or a value that is neither a branch name nor a 40-character SHA, is a 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest(
            string repositoryUrl,
            string? @ref)
        {
            this.Ref = @ref;
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest" /> class.
        /// </summary>
        public BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest()
        {
        }

    }
}