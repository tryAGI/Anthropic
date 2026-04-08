
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Arbitrary key-value metadata attached to the vault.
    /// </summary>
    public sealed partial class BetaManagedAgentsVaultMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}