
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAllConnectorsPermissionResource
    {
        /// <summary>
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: all_connectors
        /// </summary>
        /// <default>"all_connectors"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "all_connectors";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAllConnectorsPermissionResource" /> class.
        /// </summary>
        /// <param name="type">
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: all_connectors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAllConnectorsPermissionResource(
            string type = "all_connectors")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAllConnectorsPermissionResource" /> class.
        /// </summary>
        public BetaAllConnectorsPermissionResource()
        {
        }

    }
}