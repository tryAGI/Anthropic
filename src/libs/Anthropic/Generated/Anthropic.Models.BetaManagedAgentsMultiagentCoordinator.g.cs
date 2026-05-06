
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved coordinator topology with a concrete agent roster.
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentCoordinator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMultiagentCoordinatorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorType Type { get; set; }

        /// <summary>
        /// Agents the coordinator may spawn as session threads, each resolved to a specific version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentCoordinator" /> class.
        /// </summary>
        /// <param name="agents">
        /// Agents the coordinator may spawn as session threads, each resolved to a specific version.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentCoordinator(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference> agents,
            global::Anthropic.BetaManagedAgentsMultiagentCoordinatorType type)
        {
            this.Type = type;
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentCoordinator" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentCoordinator()
        {
        }
    }
}