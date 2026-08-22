
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Replacement system prompt. Up to 100,000 characters. Set to null to clear the agent's system prompt; omit to preserve it.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentWithOverridesParamsSystem
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}