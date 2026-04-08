
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation of a deleted credential.<br/>
    /// Example: {"type":"vault_credential_deleted","id":"vcrd_011CZkZEMt8gZan2iYOQfSkw"}
    /// </summary>
    public sealed partial class BetaManagedAgentsDeletedCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedCredentialTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeletedCredentialType Type { get; set; }

        /// <summary>
        /// Unique identifier of the deleted credential.
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
        /// Unique identifier of the deleted credential.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeletedCredential(
            string id,
            global::Anthropic.BetaManagedAgentsDeletedCredentialType type)
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
    }
}