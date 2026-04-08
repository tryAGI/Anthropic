
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"display_name":"Example vault","metadata":{"environment":"production"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateVaultRequestBody
    {
        /// <summary>
        /// Updated human-readable name for the vault. 1-255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omitted keys are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string?>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateVaultRequestBody" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Updated human-readable name for the vault. 1-255 characters.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omitted keys are preserved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateVaultRequestBody(
            string? displayName,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata)
        {
            this.DisplayName = displayName;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateVaultRequestBody" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateVaultRequestBody()
        {
        }
    }
}