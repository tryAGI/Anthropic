
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginDeleted
    {
        /// <summary>
        /// The deleted Plugin's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `plugin_deleted`.<br/>
        /// Default Value: plugin_deleted
        /// </summary>
        /// <default>"plugin_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The deleted Plugin's ID.
        /// </param>
        /// <param name="type">
        /// Always `plugin_deleted`.<br/>
        /// Default Value: plugin_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginDeleted(
            string id,
            string type = "plugin_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginDeleted" /> class.
        /// </summary>
        public BetaPluginDeleted()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaPluginDeleted"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaPluginDeleted FromId(string id)
        {
            return new BetaPluginDeleted
            {
                Id = id,
            };
        }

    }
}