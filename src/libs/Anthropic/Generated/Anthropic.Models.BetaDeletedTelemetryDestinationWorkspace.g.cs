
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation that a workspace was removed from a destination's list.
    /// </summary>
    public sealed partial class BetaDeletedTelemetryDestinationWorkspace
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"telemetry_destination_workspace_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "telemetry_destination_workspace_deleted";

        /// <summary>
        /// ID of the telemetry destination (`tdst_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telemetry_destination_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TelemetryDestinationId { get; set; }

        /// <summary>
        /// ID of the workspace that was removed (`wrkspc_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedTelemetryDestinationWorkspace" /> class.
        /// </summary>
        /// <param name="telemetryDestinationId">
        /// ID of the telemetry destination (`tdst_...`).
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace that was removed (`wrkspc_...`).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeletedTelemetryDestinationWorkspace(
            string telemetryDestinationId,
            string workspaceId,
            string type = "telemetry_destination_workspace_deleted")
        {
            this.Type = type;
            this.TelemetryDestinationId = telemetryDestinationId ?? throw new global::System.ArgumentNullException(nameof(telemetryDestinationId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedTelemetryDestinationWorkspace" /> class.
        /// </summary>
        public BetaDeletedTelemetryDestinationWorkspace()
        {
        }

    }
}