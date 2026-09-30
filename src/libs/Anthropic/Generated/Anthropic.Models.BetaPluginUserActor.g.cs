
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginUserActor
    {
        /// <summary>
        /// The member's email address; may be null, for example when they are no longer a member of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// A member of the organization.<br/>
        /// Default Value: user_actor
        /// </summary>
        /// <default>"user_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_actor";

        /// <summary>
        /// The member's User ID.
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
        /// Initializes a new instance of the <see cref="BetaPluginUserActor" /> class.
        /// </summary>
        /// <param name="userId">
        /// The member's User ID.
        /// </param>
        /// <param name="emailAddress">
        /// The member's email address; may be null, for example when they are no longer a member of the organization.
        /// </param>
        /// <param name="type">
        /// A member of the organization.<br/>
        /// Default Value: user_actor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginUserActor(
            string userId,
            string? emailAddress,
            string type = "user_actor")
        {
            this.EmailAddress = emailAddress;
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginUserActor" /> class.
        /// </summary>
        public BetaPluginUserActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaPluginUserActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaPluginUserActor FromUserId(string userId)
        {
            return new BetaPluginUserActor
            {
                UserId = userId,
            };
        }

    }
}