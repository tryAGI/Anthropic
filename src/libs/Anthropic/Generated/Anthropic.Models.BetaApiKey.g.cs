
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApiKey
    {
        /// <summary>
        /// RFC 3339 datetime string indicating when the API Key was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ID and type of the actor that created the API key, or `null` when the<br/>
        /// creator is not recorded (legacy, workload-identity-federated, or<br/>
        /// system-created keys).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::Anthropic.BetaCreatedBy? CreatedBy { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the API Key expires, or `null` if it never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// ID of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Partially redacted hint for the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_key_hint")]
        public string? PartialKeyHint { get; set; }

        /// <summary>
        /// The principal the API key acts as (a User or a Service Account), or `null` if the API key is not bound to a principal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal")]
        public global::Anthropic.PrincipalVariant1? Principal { get; set; }

        /// <summary>
        /// Where the API key belongs: its Workspace (`{"type": "workspace", "workspace_id": "wrkspc_..."}`, with the Workspace's real ID even when it is the organization's default Workspace), or the organization (`{"type": "organization"}`) for a principal-bound API key that has no Workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Scope Scope { get; set; }

        /// <summary>
        /// Status of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaApiKeyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaApiKeyStatus Status { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For API Keys, this is always `"api_key"`.<br/>
        /// Default Value: api_key
        /// </summary>
        /// <default>"api_key"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "api_key";

        /// <summary>
        /// Deprecated: use `scope` instead. ID of the Workspace associated with the API key, or `null` if the API key belongs to the default Workspace. Also `null` for a principal-bound API key that has no Workspace; `scope` tells the two apart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKey" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 datetime string indicating when the API Key was created.
        /// </param>
        /// <param name="id">
        /// ID of the API key.
        /// </param>
        /// <param name="name">
        /// Name of the API key.
        /// </param>
        /// <param name="scope">
        /// Where the API key belongs: its Workspace (`{"type": "workspace", "workspace_id": "wrkspc_..."}`, with the Workspace's real ID even when it is the organization's default Workspace), or the organization (`{"type": "organization"}`) for a principal-bound API key that has no Workspace.
        /// </param>
        /// <param name="status">
        /// Status of the API key.
        /// </param>
        /// <param name="createdBy">
        /// The ID and type of the actor that created the API key, or `null` when the<br/>
        /// creator is not recorded (legacy, workload-identity-federated, or<br/>
        /// system-created keys).
        /// </param>
        /// <param name="expiresAt">
        /// RFC 3339 datetime string indicating when the API Key expires, or `null` if it never expires.
        /// </param>
        /// <param name="partialKeyHint">
        /// Partially redacted hint for the API key.
        /// </param>
        /// <param name="principal">
        /// The principal the API key acts as (a User or a Service Account), or `null` if the API key is not bound to a principal.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For API Keys, this is always `"api_key"`.<br/>
        /// Default Value: api_key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApiKey(
            global::System.DateTime createdAt,
            string id,
            string name,
            global::Anthropic.Scope scope,
            global::Anthropic.BetaApiKeyStatus status,
            global::Anthropic.BetaCreatedBy? createdBy,
            global::System.DateTime? expiresAt,
            string? partialKeyHint,
            global::Anthropic.PrincipalVariant1? principal,
            string type = "api_key")
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PartialKeyHint = partialKeyHint;
            this.Principal = principal;
            this.Scope = scope;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKey" /> class.
        /// </summary>
        public BetaApiKey()
        {
        }

    }
}