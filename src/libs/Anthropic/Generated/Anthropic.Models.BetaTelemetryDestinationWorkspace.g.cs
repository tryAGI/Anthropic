
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A workspace on a telemetry destination's workspace list.<br/>
    /// Under `include`, the destination covers the workspace. Under `exclude`, the destination covers every workspace except this one. The entry doesn't have an `id`. Its `telemetry_destination_id` and `workspace_id` together identify it.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationWorkspace
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"telemetry_destination_workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "telemetry_destination_workspace";

        /// <summary>
        /// ID of the telemetry destination (`tdst_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telemetry_destination_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TelemetryDestinationId { get; set; }

        /// <summary>
        /// ID of the workspace (`wrkspc_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Time the workspace was added to the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspace" /> class.
        /// </summary>
        /// <param name="telemetryDestinationId">
        /// ID of the telemetry destination (`tdst_...`).
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace (`wrkspc_...`).
        /// </param>
        /// <param name="createdAt">
        /// Time the workspace was added to the list.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationWorkspace(
            string telemetryDestinationId,
            string workspaceId,
            global::System.DateTime createdAt,
            string type = "telemetry_destination_workspace")
        {
            this.Type = type;
            this.TelemetryDestinationId = telemetryDestinationId ?? throw new global::System.ArgumentNullException(nameof(telemetryDestinationId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspace" /> class.
        /// </summary>
        public BetaTelemetryDestinationWorkspace()
        {
        }

    }
}