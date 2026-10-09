
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The run failed or reached its time limit.
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunResultError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// Why the run did not finish.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsWorkflowRunErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsWorkflowRunError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunResultError" /> class.
        /// </summary>
        /// <param name="error">
        /// Why the run did not finish.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunResultError(
            global::Anthropic.BetaManagedAgentsWorkflowRunError error,
            string type = "error")
        {
            this.Type = type;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunResultError" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunResultError()
        {
        }

    }
}