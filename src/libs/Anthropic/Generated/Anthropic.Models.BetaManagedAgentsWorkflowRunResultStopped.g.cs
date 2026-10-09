
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent stopped the run.
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunResultStopped
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"stopped"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stopped";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunResultStopped" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunResultStopped(
            string type = "stopped")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunResultStopped" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunResultStopped()
        {
        }

    }
}