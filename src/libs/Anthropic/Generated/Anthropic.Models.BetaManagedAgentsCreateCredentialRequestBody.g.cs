
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"auth":{"type":"static_bearer","token":"bearer_exampletoken","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"},"display_name":"Example credential","metadata":{"environment":"production"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateCredentialRequestBody
    {
        /// <summary>
        /// Authentication configuration for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialCreateAuthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCredentialCreateAuth Auth { get; set; }

        /// <summary>
        /// Human-readable name for the credential. Up to 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata to attach to the credential. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateCredentialRequestBody" /> class.
        /// </summary>
        /// <param name="auth">
        /// Authentication configuration for the credential.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the credential. Up to 255 characters.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata to attach to the credential. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCreateCredentialRequestBody(
            global::Anthropic.BetaManagedAgentsCredentialCreateAuth auth,
            string? displayName,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Auth = auth;
            this.DisplayName = displayName;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateCredentialRequestBody" /> class.
        /// </summary>
        public BetaManagedAgentsCreateCredentialRequestBody()
        {
        }
    }
}