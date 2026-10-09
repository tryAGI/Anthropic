
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The run reached its time limit.<br/>
    /// Example: {"type":"timeout_error","message":"The workflow run reached its time limit."}
    /// </summary>
    public sealed partial class BetaManagedAgentsTimeoutWorkflowRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"timeout_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "timeout_error";

        /// <summary>
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTimeoutWorkflowRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTimeoutWorkflowRunError(
            string message,
            string type = "timeout_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTimeoutWorkflowRunError" /> class.
        /// </summary>
        public BetaManagedAgentsTimeoutWorkflowRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsTimeoutWorkflowRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsTimeoutWorkflowRunError FromMessage(string message)
        {
            return new BetaManagedAgentsTimeoutWorkflowRunError
            {
                Message = message,
            };
        }

    }
}