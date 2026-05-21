
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved coordinator topology with full agent definitions for each roster member.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionMultiagentCoordinator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionMultiagentCoordinatorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinatorType Type { get; set; }

        /// <summary>
        /// Full `agent` definitions the coordinator may spawn as session threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagentCoordinator" /> class.
        /// </summary>
        /// <param name="agents">
        /// Full `agent` definitions the coordinator may spawn as session threads.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionMultiagentCoordinator(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent> agents,
            global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinatorType type)
        {
            this.Type = type;
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagentCoordinator" /> class.
        /// </summary>
        public BetaManagedAgentsSessionMultiagentCoordinator()
        {
        }

    }
}