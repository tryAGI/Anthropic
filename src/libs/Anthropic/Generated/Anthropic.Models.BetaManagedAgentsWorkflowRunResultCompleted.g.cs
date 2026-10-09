
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The run's plan, a program that the agent wrote, finished. This does not say whether the work succeeded.
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunResultCompleted
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"completed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "completed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunResultCompleted" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunResultCompleted(
            string type = "completed")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunResultCompleted" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunResultCompleted()
        {
        }

    }
}