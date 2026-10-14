
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cover only the workspaces on the list.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationWorkspacesIncludeParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"include"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "include";

        /// <summary>
        /// The IDs of the workspaces on the destination's list (`wrkspc_...`). At most 100 per request.<br/>
        /// On create, these workspaces become the destination's list. If you leave `workspace_ids` out, the list starts empty. If the API refuses one of the IDs, it doesn't create the destination.<br/>
        /// On update, `workspace_ids` replaces the whole list. A workspace that stays on the list keeps its entry and its `created_at`. An empty array empties the list. If you leave `workspace_ids` out and the type stays the same, the list doesn't change. If you leave it out and the type changes, the new list starts empty. After a change to `include` without `workspace_ids`, the destination doesn't cover any workspace until one is added. After a change to `exclude` without `workspace_ids`, it covers every workspace.<br/>
        /// An ID sent more than once is added once. An archived workspace can't be added to a list. An update can keep an archived workspace that is already on the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        public global::System.Collections.Generic.IList<string>? WorkspaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspacesIncludeParams" /> class.
        /// </summary>
        /// <param name="workspaceIds">
        /// The IDs of the workspaces on the destination's list (`wrkspc_...`). At most 100 per request.<br/>
        /// On create, these workspaces become the destination's list. If you leave `workspace_ids` out, the list starts empty. If the API refuses one of the IDs, it doesn't create the destination.<br/>
        /// On update, `workspace_ids` replaces the whole list. A workspace that stays on the list keeps its entry and its `created_at`. An empty array empties the list. If you leave `workspace_ids` out and the type stays the same, the list doesn't change. If you leave it out and the type changes, the new list starts empty. After a change to `include` without `workspace_ids`, the destination doesn't cover any workspace until one is added. After a change to `exclude` without `workspace_ids`, it covers every workspace.<br/>
        /// An ID sent more than once is added once. An archived workspace can't be added to a list. An update can keep an archived workspace that is already on the list.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationWorkspacesIncludeParams(
            global::System.Collections.Generic.IList<string>? workspaceIds,
            string type = "include")
        {
            this.Type = type;
            this.WorkspaceIds = workspaceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspacesIncludeParams" /> class.
        /// </summary>
        public BetaTelemetryDestinationWorkspacesIncludeParams()
        {
        }

    }
}