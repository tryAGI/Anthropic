
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"type":"github_repository","id":"sesrsc_011CZkZCKr6eXyl0gWMOdQiu","url":"https://github.com/example-org/example-repo","mount_path":"/workspace/example-repo","checkout":{"type":"branch","name":"main"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}
    /// </summary>
    public sealed partial class BetaManagedAgentsGitHubRepositoryResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGitHubRepositoryResourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRepositoryCheckoutJsonConverter))]
        public global::Anthropic.BetaManagedAgentsRepositoryCheckout? Checkout { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsGitHubRepositoryResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="mountPath"></param>
        /// <param name="createdAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="type"></param>
        /// <param name="checkout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsGitHubRepositoryResource(
            string id,
            string url,
            string mountPath,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceType type,
            global::Anthropic.BetaManagedAgentsRepositoryCheckout? checkout)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.Checkout = checkout;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsGitHubRepositoryResource" /> class.
        /// </summary>
        public BetaManagedAgentsGitHubRepositoryResource()
        {
        }
    }
}