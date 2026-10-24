
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
        /// <default>"organization_disabled_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "organization_disabled_error";

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
            string type = "organization_disabled_error")
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