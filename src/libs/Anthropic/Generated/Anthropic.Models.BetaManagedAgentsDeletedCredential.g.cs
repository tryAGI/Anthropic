
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation of a deleted credential.<br/>
    /// Example: {"type":"vault_credential_deleted","id":"vcrd_011CZkZEMt8gZan2iYPQfSkw"}
    /// </summary>
    public sealed partial class BetaManagedAgentsDeletedCredential
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"vault_credential_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "vault_credential_deleted";

        /// <summary>
        /// The unique ID of the deleted credential (`vcrd_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedCredential" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the deleted credential (`vcrd_...`).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeletedCredential(
            string id,
            string type = "vault_credential_deleted")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedCredential" /> class.
        /// </summary>
        public BetaManagedAgentsDeletedCredential()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsDeletedCredential"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsDeletedCredential FromId(string id)
        {
            return new BetaManagedAgentsDeletedCredential
            {
                Id = id,
            };
        }

    }
}