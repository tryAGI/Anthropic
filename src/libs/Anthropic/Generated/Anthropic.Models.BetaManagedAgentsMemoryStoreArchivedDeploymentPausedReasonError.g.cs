
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A memory store referenced by the deployment is archived.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError(
            global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError()
        {
        }

    }
}