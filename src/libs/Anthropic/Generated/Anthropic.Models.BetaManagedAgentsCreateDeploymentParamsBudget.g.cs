
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Enforced spend ceiling stamped onto each session created from this deployment, copied at session-creation time. Omit to leave sessions uncapped. The deployment agent's model must have a public list price, or the request is rejected; a multiagent roster is re-validated in full when each fire copies the cap, which fails closed the same way.
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateDeploymentParamsBudget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}