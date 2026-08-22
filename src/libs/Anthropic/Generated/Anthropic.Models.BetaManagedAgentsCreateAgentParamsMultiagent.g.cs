
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Multiagent orchestration configuration. Currently supports the `coordinator` topology with a roster of 1-20 agents.
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateAgentParamsMultiagent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}