
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApiKeyUserActor
    {
        /// <summary>
        /// Principal type. Always `"user_actor"` for a User.<br/>
        /// Default Value: user_actor
        /// </summary>
        /// <default>"user_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_actor";

        /// <summary>
        /// ID of the User the API key acts as.
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
        /// Initializes a new instance of the <see cref="BetaApiKeyUserActor" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the User the API key acts as.
        /// </param>
        /// <param name="type">
        /// Principal type. Always `"user_actor"` for a User.<br/>
        /// Default Value: user_actor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApiKeyUserActor(
            string userId,
            string type = "user_actor")
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyUserActor" /> class.
        /// </summary>
        public BetaApiKeyUserActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaApiKeyUserActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaApiKeyUserActor FromUserId(string userId)
        {
            return new BetaApiKeyUserActor
            {
                UserId = userId,
            };
        }

    }
}