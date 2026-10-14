
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cover every workspace of the organization. Doesn't take `workspace_ids`.<br/>
    /// An update that sets `all` empties the destination's workspace list.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationWorkspacesAllParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"all"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "all";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspacesAllParams" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationWorkspacesAllParams(
            string type = "all")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspacesAllParams" /> class.
        /// </summary>
        public BetaTelemetryDestinationWorkspacesAllParams()
        {
        }

    }
}