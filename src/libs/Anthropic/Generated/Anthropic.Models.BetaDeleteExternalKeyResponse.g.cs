
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteExternalKeyResponse
    {
        /// <summary>
        /// ID of the deleted External Key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: external_key_deleted
        /// </summary>
        /// <default>"external_key_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external_key_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteExternalKeyResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted External Key.
        /// </param>
        /// <param name="type">
        /// Default Value: external_key_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteExternalKeyResponse(
            string id,
            string type = "external_key_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteExternalKeyResponse" /> class.
        /// </summary>
        public BetaDeleteExternalKeyResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeleteExternalKeyResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeleteExternalKeyResponse FromId(string id)
        {
            return new BetaDeleteExternalKeyResponse
            {
                Id = id,
            };
        }

    }
}