
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedVaultTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeletedVaultType Type { get; set; }

        /// <summary>
        /// Unique identifier of the deleted vault.
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
        /// Unique identifier of the deleted vault.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeletedVault(
            string id,
            global::Anthropic.BetaManagedAgentsDeletedVaultType type)
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
    }
}