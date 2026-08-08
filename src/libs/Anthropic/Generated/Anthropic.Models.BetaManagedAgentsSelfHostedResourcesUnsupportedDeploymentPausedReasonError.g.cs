
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType Type { get; set; }

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
            global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType type)
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