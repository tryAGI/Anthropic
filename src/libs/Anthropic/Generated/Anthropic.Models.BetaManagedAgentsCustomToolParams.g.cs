
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A custom tool that is executed by the API client rather than the agent. When the agent calls this tool, an `agent.custom_tool_use` event is emitted and the session goes idle, waiting for the client to provide the result via a `user.custom_tool_result` event.
    /// </summary>
    public sealed partial class BetaManagedAgentsCustomToolParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCustomToolParamsType Type { get; set; }

        /// <summary>
        /// Unique name for the tool. 1-128 characters; letters, digits, underscores, and hyphens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what the tool does, shown to the agent to help it decide when to use the tool. 1-1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// JSON Schema defining the expected input parameters for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCustomToolInputSchema InputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomToolParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique name for the tool. 1-128 characters; letters, digits, underscores, and hyphens.
        /// </param>
        /// <param name="description">
        /// Description of what the tool does, shown to the agent to help it decide when to use the tool. 1-1024 characters.
        /// </param>
        /// <param name="inputSchema">
        /// JSON Schema defining the expected input parameters for the tool.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCustomToolParams(
            string name,
            string description,
            global::Anthropic.BetaManagedAgentsCustomToolInputSchema inputSchema,
            global::Anthropic.BetaManagedAgentsCustomToolParamsType type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomToolParams" /> class.
        /// </summary>
        public BetaManagedAgentsCustomToolParams()
        {
        }
    }
}