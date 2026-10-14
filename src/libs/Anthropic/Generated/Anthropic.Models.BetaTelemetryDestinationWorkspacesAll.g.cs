
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The destination covers every workspace of the organization, including the default workspace, archived workspaces, and workspaces created later. It doesn't have a list.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationWorkspacesAll
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
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspacesAll" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationWorkspacesAll(
            string type = "all")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationWorkspacesAll" /> class.
        /// </summary>
        public BetaTelemetryDestinationWorkspacesAll()
        {
        }

    }
}