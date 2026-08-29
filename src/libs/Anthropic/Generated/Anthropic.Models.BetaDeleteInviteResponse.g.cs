
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteInviteResponse
    {
        /// <summary>
        /// ID of the Invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For Invites, this is always `"invite_deleted"`.<br/>
        /// Default Value: invite_deleted
        /// </summary>
        /// <default>"invite_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invite_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteInviteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the Invite.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Invites, this is always `"invite_deleted"`.<br/>
        /// Default Value: invite_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteInviteResponse(
            string id,
            string type = "invite_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteInviteResponse" /> class.
        /// </summary>
        public BetaDeleteInviteResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeleteInviteResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeleteInviteResponse FromId(string id)
        {
            return new BetaDeleteInviteResponse
            {
                Id = id,
            };
        }

    }
}