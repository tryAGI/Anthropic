
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateMemoryStoreRequestBody
    {
        /// <summary>
        /// New human-readable name for the store. 1–255 characters; no control characters. Renaming changes the slug used for the store's `mount_path` in sessions created after the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description for the store, up to 1024 characters. Pass an empty string to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string?>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateMemoryStoreRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// New human-readable name for the store. 1–255 characters; no control characters. Renaming changes the slug used for the store's `mount_path` in sessions created after the update.
        /// </param>
        /// <param name="description">
        /// New description for the store, up to 1024 characters. Pass an empty string to clear it.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateMemoryStoreRequestBody(
            string? name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateMemoryStoreRequestBody" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateMemoryStoreRequestBody()
        {
        }
    }
}