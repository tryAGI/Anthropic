
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The caller invoked the pause endpoint on the deployment.
    /// </summary>
    public sealed partial class BetaManagedAgentsManualDeploymentPausedReason
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"manual"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "manual";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsManualDeploymentPausedReason" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsManualDeploymentPausedReason(
            string type = "manual")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsManualDeploymentPausedReason" /> class.
        /// </summary>
        public BetaManagedAgentsManualDeploymentPausedReason()
        {
        }

    }
}