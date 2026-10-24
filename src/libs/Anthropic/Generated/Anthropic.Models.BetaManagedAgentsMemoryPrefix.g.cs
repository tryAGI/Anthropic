
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A directory marker that [List Memories](https://platform.claude.com/docs/en/api/beta/memory_stores/memories/list) returns instead of the memories below the requested `depth`.<br/>
    /// It stands for one or more memories whose paths start with `path`. It isn't a stored object and doesn't have an ID. Each marker counts toward the page `limit`.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryPrefix
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"memory_prefix"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory_prefix";

        /// <summary>
        /// The rolled-up path prefix, including a trailing `/` (e.g. `/projects/foo/`). Pass this value as `path_prefix` on a subsequent list call to drill into the directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPrefix" /> class.
        /// </summary>
        /// <param name="path">
        /// The rolled-up path prefix, including a trailing `/` (e.g. `/projects/foo/`). Pass this value as `path_prefix` on a subsequent list call to drill into the directory.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryPrefix(
            string path,
            string type = "memory_prefix")
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPrefix" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryPrefix()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsMemoryPrefix"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsMemoryPrefix FromPath(string path)
        {
            return new BetaManagedAgentsMemoryPrefix
            {
                Path = path,
            };
        }

    }
}