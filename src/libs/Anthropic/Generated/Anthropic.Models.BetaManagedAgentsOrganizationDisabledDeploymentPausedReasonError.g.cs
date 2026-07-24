
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The deployment's organization is disabled.
    /// </summary>
    public sealed partial class BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError(
            global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError()
        {
        }

    }
}