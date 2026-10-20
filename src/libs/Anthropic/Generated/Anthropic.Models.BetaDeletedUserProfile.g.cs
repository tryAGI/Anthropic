
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"id":"uprof_011CZkZCu8hGbp5mYRQgUmz9","type":"user_profile_deleted"}
    /// </summary>
    public sealed partial class BetaDeletedUserProfile
    {
        /// <summary>
        /// Identifier of the deleted user profile, prefixed `uprof_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type. Always `user_profile_deleted`.
        /// </summary>
        /// <default>"user_profile_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_profile_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedUserProfile" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the deleted user profile, prefixed `uprof_`.
        /// </param>
        /// <param name="type">
        /// Object type. Always `user_profile_deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeletedUserProfile(
            string id,
            string type = "user_profile_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedUserProfile" /> class.
        /// </summary>
        public BetaDeletedUserProfile()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeletedUserProfile"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeletedUserProfile FromId(string id)
        {
            return new BetaDeletedUserProfile
            {
                Id = id,
            };
        }

    }
}