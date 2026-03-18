
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Object mapping capability names to their support details. Keys are always present for all known capabilities.
    /// </summary>
    public sealed partial class ModelInfoCapabilities
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}