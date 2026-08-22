
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why the deployment is paused. Non-null exactly when status is paused; null otherwise.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeploymentPausedReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}