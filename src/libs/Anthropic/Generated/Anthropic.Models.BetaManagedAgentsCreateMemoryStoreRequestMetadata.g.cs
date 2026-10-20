
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Key-value pairs for your own use, such as the end user that the store belongs to. The agent doesn't see them.<br/>
    /// A store has at most 16 pairs. Keys are 1 to 64 characters long and values at most 512 characters.
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateMemoryStoreRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}