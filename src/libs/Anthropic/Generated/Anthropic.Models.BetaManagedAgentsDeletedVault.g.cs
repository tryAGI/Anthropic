
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation of a deleted vault.<br/>
    /// Example: {"type":"vault_deleted","id":"vlt_011CZkZDLs7fYzm1hXNPeRjv"}
    /// </summary>
    public sealed partial class BetaManagedAgentsDeletedVault
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"vault_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "vault_deleted";

        /// <summary>
        /// The unique ID of the deleted vault (`vlt_...`).
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedVault" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the deleted vault (`vlt_...`).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeletedVault(
            string id,
            string type = "vault_deleted")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedVault" /> class.
        /// </summary>
        public BetaManagedAgentsDeletedVault()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsDeletedVault"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsDeletedVault FromId(string id)
        {
            return new BetaManagedAgentsDeletedVault
            {
                Id = id,
            };
        }

    }
}