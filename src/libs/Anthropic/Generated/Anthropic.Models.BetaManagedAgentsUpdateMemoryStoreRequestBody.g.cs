
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateMemoryStoreRequestBody
    {
        /// <summary>
        /// The new name of the memory store, 1 to 255 characters long, without control characters.<br/>
        /// Sessions created after the change use the new name for the store's directory under `/mnt/memory/`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description for the store, up to 1,024 characters. Pass an empty string to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Changes to apply to the memory store's metadata. Keys you leave out keep their values.<br/>
        /// Set a key to a string to add or replace it, or to `null` to remove it. After the change, the metadata can hold at most 16 key-value pairs. Keys are 1 to 64 characters long and values at most 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateMemoryStoreRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name of the memory store, 1 to 255 characters long, without control characters.<br/>
        /// Sessions created after the change use the new name for the store's directory under `/mnt/memory/`.
        /// </param>
        /// <param name="description">
        /// New description for the store, up to 1,024 characters. Pass an empty string to clear it.
        /// </param>
        /// <param name="metadata">
        /// Changes to apply to the memory store's metadata. Keys you leave out keep their values.<br/>
        /// Set a key to a string to add or replace it, or to `null` to remove it. After the change, the metadata can hold at most 16 key-value pairs. Keys are 1 to 64 characters long and values at most 512 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateMemoryStoreRequestBody(
            string? name,
            string? description,
            object? metadata)
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