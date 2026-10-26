
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A referenced resource no longer exists and its kind was not reported.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"session_resource_not_found_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session_resource_not_found_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError(
            string type = "session_resource_not_found_error")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError()
        {
        }

    }
}