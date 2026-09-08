
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user within the organization. `name` and `email_address` are<br/>
    /// null when the underlying account is unavailable or has been deleted;<br/>
    /// `deleted` is true only for deleted accounts.
    /// </summary>
    public sealed partial class BetaUserActorSchema
    {
        /// <summary>
        /// True only when the underlying account has been deleted.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The user's email address. Null when the account is unavailable or has been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// The user's current display name. Null when the account is unavailable, has been deleted, or has no name set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Actor type. Always `user_actor`.<br/>
        /// Default Value: user_actor
        /// </summary>
        /// <default>"user_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_actor";

        /// <summary>
        /// Tagged ID of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserActorSchema" /> class.
        /// </summary>
        /// <param name="deleted">
        /// True only when the underlying account has been deleted.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userId">
        /// Tagged ID of the user.
        /// </param>
        /// <param name="emailAddress">
        /// The user's email address. Null when the account is unavailable or has been deleted.
        /// </param>
        /// <param name="name">
        /// The user's current display name. Null when the account is unavailable, has been deleted, or has no name set.
        /// </param>
        /// <param name="type">
        /// Actor type. Always `user_actor`.<br/>
        /// Default Value: user_actor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserActorSchema(
            bool deleted,
            string userId,
            string? emailAddress,
            string? name,
            string type = "user_actor")
        {
            this.Deleted = deleted;
            this.EmailAddress = emailAddress;
            this.Name = name;
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserActorSchema" /> class.
        /// </summary>
        public BetaUserActorSchema()
        {
        }

    }
}