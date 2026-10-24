
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A scheduled fire recorded a failed run whose error auto-pauses the deployment.
    /// </summary>
    public sealed partial class BetaManagedAgentsErrorDeploymentPausedReason
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// The failed run's error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentPausedReasonErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsErrorDeploymentPausedReason" /> class.
        /// </summary>
        /// <param name="error">
        /// The failed run's error.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsErrorDeploymentPausedReason(
            global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError error,
            string type = "error")
        {
            this.Type = type;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsErrorDeploymentPausedReason" /> class.
        /// </summary>
        public BetaManagedAgentsErrorDeploymentPausedReason()
        {
        }

    }
}