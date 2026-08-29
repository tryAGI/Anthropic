
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUser
    {
        /// <summary>
        /// RFC 3339 datetime string indicating when the User joined the Organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AddedAt { get; set; }

        /// <summary>
        /// Email of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// ID of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Organization role of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaOrganizationRoleSchemaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaOrganizationRoleSchema Role { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Users, this is always `"user"`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUser" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// RFC 3339 datetime string indicating when the User joined the Organization.
        /// </param>
        /// <param name="email">
        /// Email of the User.
        /// </param>
        /// <param name="id">
        /// ID of the User.
        /// </param>
        /// <param name="name">
        /// Name of the User.
        /// </param>
        /// <param name="role">
        /// Organization role of the User.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Users, this is always `"user"`.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUser(
            global::System.DateTime addedAt,
            string email,
            string id,
            string name,
            global::Anthropic.BetaOrganizationRoleSchema role,
            string type = "user")
        {
            this.AddedAt = addedAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUser" /> class.
        /// </summary>
        public BetaUser()
        {
        }

    }
}