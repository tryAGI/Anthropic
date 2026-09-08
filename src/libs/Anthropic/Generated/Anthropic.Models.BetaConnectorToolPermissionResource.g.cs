
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaConnectorToolPermissionResource
    {
        /// <summary>
        /// ID of the connector the permission applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Published name of the connector tool the permission applies to.<br/>
        /// When the published name contains characters outside `[a-zA-Z0-9_-]` (or<br/>
        /// collides with a reserved form), it is server-encoded into a stable<br/>
        /// `{prefix}_{32-hex}` form — a shortened readable prefix of the name plus<br/>
        /// a hash — from which the published name is not recoverable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: connector_tool
        /// </summary>
        /// <default>"connector_tool"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "connector_tool";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConnectorToolPermissionResource" /> class.
        /// </summary>
        /// <param name="connectorId">
        /// ID of the connector the permission applies to.
        /// </param>
        /// <param name="toolName">
        /// Published name of the connector tool the permission applies to.<br/>
        /// When the published name contains characters outside `[a-zA-Z0-9_-]` (or<br/>
        /// collides with a reserved form), it is server-encoded into a stable<br/>
        /// `{prefix}_{32-hex}` form — a shortened readable prefix of the name plus<br/>
        /// a hash — from which the published name is not recoverable.
        /// </param>
        /// <param name="type">
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: connector_tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaConnectorToolPermissionResource(
            string connectorId,
            string toolName,
            string type = "connector_tool")
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConnectorToolPermissionResource" /> class.
        /// </summary>
        public BetaConnectorToolPermissionResource()
        {
        }

    }
}