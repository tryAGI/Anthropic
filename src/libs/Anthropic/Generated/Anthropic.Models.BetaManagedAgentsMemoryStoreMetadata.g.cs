
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Key-value pairs for your own use, such as the end user that the store belongs to.<br/>
    /// A store has at most 16 pairs. Keys are 1 to 64 characters long and values at most 512 characters. You can't filter lists by metadata.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryStoreMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}