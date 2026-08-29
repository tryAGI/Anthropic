
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Named non-human identity within the caller's organization.<br/>
    /// A service account is a pure identity: name + org. Authorization lives on<br/>
    /// whatever references it (federation rules).
    /// </summary>
    public sealed partial class BetaServiceAccount
    {
        /// <summary>
        /// If set, this service account is archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that archived this service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_by_actor_id")]
        public string? ArchivedByActorId { get; set; }

        /// <summary>
        /// When this service account was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that created this service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_actor_id")]
        public string? CreatedByActorId { get; set; }

        /// <summary>
        /// Optional free-text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Tagged ID of the service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Admin-chosen slug identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Org-level role. A federation rule may only be created or retargeted to grant `org:admin` scope when this is `admin`. A rule granting `org:admin` whose target is later demoted to `developer` is rejected at token exchange. Rules granting `org:admin` are managed in the Console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaServiceAccountOrganizationRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaServiceAccountOrganizationRole OrganizationRole { get; set; }

        /// <summary>
        /// Default Value: service_account
        /// </summary>
        /// <default>"service_account"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account";

        /// <summary>
        /// When this service account was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that last updated this service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by_actor_id")]
        public string? UpdatedByActorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccount" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When this service account was created.
        /// </param>
        /// <param name="id">
        /// Tagged ID of the service account.
        /// </param>
        /// <param name="name">
        /// Admin-chosen slug identifier.
        /// </param>
        /// <param name="organizationRole">
        /// Org-level role. A federation rule may only be created or retargeted to grant `org:admin` scope when this is `admin`. A rule granting `org:admin` whose target is later demoted to `developer` is rejected at token exchange. Rules granting `org:admin` are managed in the Console.
        /// </param>
        /// <param name="updatedAt">
        /// When this service account was last updated.
        /// </param>
        /// <param name="archivedAt">
        /// If set, this service account is archived.
        /// </param>
        /// <param name="archivedByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that archived this service account.
        /// </param>
        /// <param name="createdByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that created this service account.
        /// </param>
        /// <param name="description">
        /// Optional free-text description.
        /// </param>
        /// <param name="updatedByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that last updated this service account.
        /// </param>
        /// <param name="type">
        /// Default Value: service_account
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServiceAccount(
            global::System.DateTime createdAt,
            string id,
            string name,
            global::Anthropic.BetaServiceAccountOrganizationRole organizationRole,
            global::System.DateTime updatedAt,
            global::System.DateTime? archivedAt,
            string? archivedByActorId,
            string? createdByActorId,
            string? description,
            string? updatedByActorId,
            string type = "service_account")
        {
            this.ArchivedAt = archivedAt;
            this.ArchivedByActorId = archivedByActorId;
            this.CreatedAt = createdAt;
            this.CreatedByActorId = createdByActorId;
            this.Description = description;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationRole = organizationRole;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UpdatedByActorId = updatedByActorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccount" /> class.
        /// </summary>
        public BetaServiceAccount()
        {
        }

    }
}