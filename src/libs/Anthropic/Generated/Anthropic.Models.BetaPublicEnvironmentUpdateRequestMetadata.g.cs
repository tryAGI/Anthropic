
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// User-provided metadata key-value pairs. Set a value to null or empty string to delete the key.
    /// </summary>
    public sealed partial class BetaPublicEnvironmentUpdateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}