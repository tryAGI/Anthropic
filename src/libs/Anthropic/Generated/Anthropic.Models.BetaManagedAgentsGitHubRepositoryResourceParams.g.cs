
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Mount a GitHub repository into the session's container.<br/>
    /// Example: {"type":"github_repository","url":"https://github.com/example-org/example-repo","authorization_token":"ghp_exampletoken"}
    /// </summary>
    public sealed partial class BetaManagedAgentsGitHubRepositoryResourceParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGitHubRepositoryResourceParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParamsType Type { get; set; }

        /// <summary>
        /// Github URL of the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// GitHub authorization token used to clone the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorizationToken { get; set; }

        /// <summary>
        /// Mount path in the container. Defaults to `/workspace/&lt;repo-name&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        public string? MountPath { get; set; }

        /// <summary>
        /// Branch or commit to check out. Defaults to the repository's default branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRepositoryCheckoutJsonConverter))]
        public global::Anthropic.BetaManagedAgentsRepositoryCheckout? Checkout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsGitHubRepositoryResourceParams" /> class.
        /// </summary>
        /// <param name="url">
        /// Github URL of the repository
        /// </param>
        /// <param name="authorizationToken">
        /// GitHub authorization token used to clone the repository.
        /// </param>
        /// <param name="type"></param>
        /// <param name="mountPath">
        /// Mount path in the container. Defaults to `/workspace/&lt;repo-name&gt;`.
        /// </param>
        /// <param name="checkout">
        /// Branch or commit to check out. Defaults to the repository's default branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsGitHubRepositoryResourceParams(
            string url,
            string authorizationToken,
            global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParamsType type,
            string? mountPath,
            global::Anthropic.BetaManagedAgentsRepositoryCheckout? checkout)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AuthorizationToken = authorizationToken ?? throw new global::System.ArgumentNullException(nameof(authorizationToken));
            this.MountPath = mountPath;
            this.Checkout = checkout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsGitHubRepositoryResourceParams" /> class.
        /// </summary>
        public BetaManagedAgentsGitHubRepositoryResourceParams()
        {
        }
    }
}