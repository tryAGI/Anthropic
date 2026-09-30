
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginComponent
    {
        /// <summary>
        /// What the component declares about itself; always null for MCP servers, hooks, and CLIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The component's name: a skill's, command's or agent's name, an MCP server's key in the manifest, the event a hook runs on, or a CLI's executable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The kind of component.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaPluginComponentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaPluginComponentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginComponent" /> class.
        /// </summary>
        /// <param name="name">
        /// The component's name: a skill's, command's or agent's name, an MCP server's key in the manifest, the event a hook runs on, or a CLI's executable.
        /// </param>
        /// <param name="type">
        /// The kind of component.
        /// </param>
        /// <param name="description">
        /// What the component declares about itself; always null for MCP servers, hooks, and CLIs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginComponent(
            string name,
            global::Anthropic.BetaPluginComponentType type,
            string? description)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginComponent" /> class.
        /// </summary>
        public BetaPluginComponent()
        {
        }

    }
}