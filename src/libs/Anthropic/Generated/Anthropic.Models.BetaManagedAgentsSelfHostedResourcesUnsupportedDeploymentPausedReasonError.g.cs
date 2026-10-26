
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The deployment configures resources, but its environment is self-hosted and cannot mount them.
    /// </summary>
    public sealed partial class BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"self_hosted_resources_unsupported_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "self_hosted_resources_unsupported_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError(
            string type = "self_hosted_resources_unsupported_error")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError()
        {
        }

    }
}