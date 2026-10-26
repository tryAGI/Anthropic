
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Specification for an Agent. Provide a specific `version` or use the short-form `agent="agent_id"` for the most recent version
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"agent"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent";

        /// <summary>
        /// The `agent` ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The specific `agent` version to use. Omit to use the latest version. Must be at least 1 if specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentParams" /> class.
        /// </summary>
        /// <param name="id">
        /// The `agent` ID.
        /// </param>
        /// <param name="version">
        /// The specific `agent` version to use. Omit to use the latest version. Must be at least 1 if specified.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentParams(
            string id,
            int? version,
            string type = "agent")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentParams" /> class.
        /// </summary>
        public BetaManagedAgentsAgentParams()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAgentParams"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAgentParams FromId(string id)
        {
            return new BetaManagedAgentsAgentParams
            {
                Id = id,
            };
        }

    }
}