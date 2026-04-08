
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentParamsType Type { get; set; }

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
        /// <param name="type"></param>
        /// <param name="version">
        /// The specific `agent` version to use. Omit to use the latest version. Must be at least 1 if specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentParams(
            string id,
            global::Anthropic.BetaManagedAgentsAgentParamsType type,
            int? version)
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
    }
}