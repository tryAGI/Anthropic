
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteUserResponse
    {
        /// <summary>
        /// ID of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For Users, this is always `"user_deleted"`.<br/>
        /// Default Value: user_deleted
        /// </summary>
        /// <default>"user_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteUserResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the User.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Users, this is always `"user_deleted"`.<br/>
        /// Default Value: user_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteUserResponse(
            string id,
            string type = "user_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteUserResponse" /> class.
        /// </summary>
        public BetaDeleteUserResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeleteUserResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeleteUserResponse FromId(string id)
        {
            return new BetaDeleteUserResponse
            {
                Id = id,
            };
        }

    }
}