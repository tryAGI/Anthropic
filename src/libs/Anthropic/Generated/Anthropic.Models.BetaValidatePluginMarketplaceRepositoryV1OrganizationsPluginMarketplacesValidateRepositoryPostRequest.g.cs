
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The repository to validate: its URL, and optionally the branch or commit<br/>
    /// to read. `repository_url` is required and any other field is refused; a<br/>
    /// `repository_url` or `ref` that fails the checks listed on its field is a 400,<br/>
    /// and a repository, branch, or commit that cannot be read is reported in the<br/>
    /// response, not refused.
    /// </summary>
    public sealed partial class BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest
    {
        /// <summary>
        /// The branch to validate the tip of, or the full 40-character SHA of the commit to validate. When omitted, the branch a synchronization would read (usually the repository's default branch); if that is not the default branch, the report's `ref` says which branch was read. An empty string, a value longer than 255 characters, or one that contains `..` or a character other than ASCII letters, digits, `.`, `_`, `-`, `+`, and `/`, is a 400. Any other value that is not a 40-character SHA is read as a branch name; if the repository has no such branch, the response is a report with `valid: false`, not a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The `https://` URL of a public repository on github.com that holds the marketplace. A URL longer than 2,048 characters, on any other host or scheme, with a port other than 443 or 80, with credentials in it, or that does not name exactly `owner/repo` (a trailing `.git` or `/` is accepted) is a 400. A private or missing repository is reported in the response, not refused.
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
        /// The `https://` URL of a public repository on github.com that holds the marketplace. A URL longer than 2,048 characters, on any other host or scheme, with a port other than 443 or 80, with credentials in it, or that does not name exactly `owner/repo` (a trailing `.git` or `/` is accepted) is a 400. A private or missing repository is reported in the response, not refused.
        /// </param>
        /// <param name="ref">
        /// The branch to validate the tip of, or the full 40-character SHA of the commit to validate. When omitted, the branch a synchronization would read (usually the repository's default branch); if that is not the default branch, the report's `ref` says which branch was read. An empty string, a value longer than 255 characters, or one that contains `..` or a character other than ASCII letters, digits, `.`, `_`, `-`, `+`, and `/`, is a 400. Any other value that is not a 40-character SHA is read as a branch name; if the repository has no such branch, the response is a report with `valid: false`, not a 400.
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