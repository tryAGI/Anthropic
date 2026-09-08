
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaConnectorPermissionResource
    {
        /// <summary>
        /// ID of the connector the permission applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: connector
        /// </summary>
        /// <default>"connector"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "connector";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConnectorPermissionResource" /> class.
        /// </summary>
        /// <param name="connectorId">
        /// ID of the connector the permission applies to.
        /// </param>
        /// <param name="type">
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: connector
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaConnectorPermissionResource(
            string connectorId,
            string type = "connector")
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConnectorPermissionResource" /> class.
        /// </summary>
        public BetaConnectorPermissionResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaConnectorPermissionResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaConnectorPermissionResource FromConnectorId(string connectorId)
        {
            return new BetaConnectorPermissionResource
            {
                ConnectorId = connectorId,
            };
        }

    }
}