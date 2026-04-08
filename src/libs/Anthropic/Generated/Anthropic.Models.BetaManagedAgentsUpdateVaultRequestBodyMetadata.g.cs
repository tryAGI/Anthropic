
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omitted keys are preserved.
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateVaultRequestBodyMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}