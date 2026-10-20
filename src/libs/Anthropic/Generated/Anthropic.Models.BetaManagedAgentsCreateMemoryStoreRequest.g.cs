
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for creating a `memory_store`.
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateMemoryStoreRequest
    {
        /// <summary>
        /// The name of the memory store, 1 to 255 characters long, without control characters. Names don't have to be unique in a workspace.<br/>
        /// In a session, the store's directory under `/mnt/memory/` is based on this name. The name is lowercased and every run of characters other than ASCII letters and digits becomes one hyphen. The session's memory store resource gives the exact path in `mount_path`.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#how-the-agent-accesses-memory) to learn more about how agents access memory stores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Free-text description of what the store contains, up to 1,024 characters. Included in the agent's system prompt when the store is attached, so word it to be useful to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Key-value pairs for your own use, such as the end user that the store belongs to. The agent doesn't see them.<br/>
        /// A store has at most 16 pairs. Keys are 1 to 64 characters long and values at most 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateMemoryStoreRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the memory store, 1 to 255 characters long, without control characters. Names don't have to be unique in a workspace.<br/>
        /// In a session, the store's directory under `/mnt/memory/` is based on this name. The name is lowercased and every run of characters other than ASCII letters and digits becomes one hyphen. The session's memory store resource gives the exact path in `mount_path`.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#how-the-agent-accesses-memory) to learn more about how agents access memory stores.
        /// </param>
        /// <param name="description">
        /// Free-text description of what the store contains, up to 1,024 characters. Included in the agent's system prompt when the store is attached, so word it to be useful to the agent.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs for your own use, such as the end user that the store belongs to. The agent doesn't see them.<br/>
        /// A store has at most 16 pairs. Keys are 1 to 64 characters long and values at most 512 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCreateMemoryStoreRequest(
            string name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateMemoryStoreRequest" /> class.
        /// </summary>
        public BetaManagedAgentsCreateMemoryStoreRequest()
        {
        }

    }
}